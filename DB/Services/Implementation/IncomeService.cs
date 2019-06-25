using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DB.Model.Implementation;
using DB.Model.Interfaces;
using DB.Services.Interfaces;

namespace DB.Services.Implementation
{
    public class IncomeService : IIncomeService
    {
        public IList<IIncomeData> GetIncomeForBuildings(IEnumerable<int> buildingIds = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            var dataset = new List<IIncomeData>();
            var profitList = new List<IBuildingProfit>();
            IEnumerable<Budynki> buildingList = null;
            using (var dbContext = new DBProjectEntities())
            {
                var result = dbContext.Budynki.AsQueryable();
                if (buildingIds != null)
                {
                    result = result.Where(j => buildingIds.Contains(j.id_budynku));
                }

                if (result.Count() != 0)
                {
                    buildingList = result;
                }

                if (buildingList == null)
                {
                    return dataset;
                }

                foreach (var building in buildingList)
                {
                    var totalIncome = 0.0;
                    var totalExpense = 0.0;
                    var profit = new BuildingProfit { IncomeList = new List<Platnosci>(), ExpensureList = new List<FakturyNapraw>() };
                    var residences = dbContext.Mieszkania.Where(x => x.id_budynku == building.id_budynku)
                        .Include(i => i.Usterki
                            .Select(s => s.Naprawy
                                .Select(ss => ss.FakturyNapraw)))
                        .Include(i => i.Wynajmy.Select(s => s.Platnosci));

                    foreach (var residence in residences)
                    {
                        Func<Platnosci, bool> incomeFilterPredicate = (x) => true;
                        Func<FakturyNapraw, bool> expenseFilterPredicate = (x) => true;
                        if (startDate.HasValue)
                        {
                            incomeFilterPredicate = (x) =>  x.data_platnosci > startDate.Value;
                            expenseFilterPredicate = (x) => x.data_platnosci > startDate.Value;
                        }

                        if (endDate.HasValue)
                        {
                            incomeFilterPredicate = (x) => incomeFilterPredicate(x) && x.data_platnosci < endDate.Value;
                            expenseFilterPredicate = (x) => expenseFilterPredicate(x) && x.data_platnosci < endDate.Value;
                        }

                        var incomeBills = residence.Wynajmy.SelectMany(s => s.Platnosci).Where(incomeFilterPredicate).ToList();
                        var expenseBills = residence.Usterki.SelectMany(s => s.Naprawy.SelectMany(ss => ss.FakturyNapraw).Where(expenseFilterPredicate)).ToList();
                        incomeBills.ForEach(x => totalIncome += x.cena);
                        expenseBills.ForEach(x => totalExpense += x.cena);
                        foreach (var incomeBill in incomeBills)
                        {
                            profit.IncomeList.Add(incomeBill);
                        }

                        foreach (var expenseBill in expenseBills)
                        {
                            profit.ExpensureList.Add(expenseBill);
                        }
                    }

                    profit.IncomeFromBuilding = totalIncome;
                    profit.ExpensureOnBuilding = totalExpense;

                    profitList.Add(profit);
                    var income = profit.IncomeList.Sum(x => x.cena);
                    var expense = profit.ExpensureList.Sum(x => x.cena);

                    var incomeData = new IncomeData
                    {
                        Address = building.adres_budynku,
                        Expense = expense,
                        Profit = income - expense,
                        Income = income,
                        BuildingId = building.id_budynku
                    };
                    dataset.Add(incomeData);
                }

            }

            return dataset;
        }
    }
}