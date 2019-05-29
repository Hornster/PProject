using Desktop.Network.Implementation;
using Desktop.Network.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Forms.Workspace
{
    public partial class FormBuildings : Form
    {
        public FormBuildings()
        {
            InitializeComponent();
            IBuildingResource buildingResource = new MockBuildingResource();
            dataGridViewBuildings.AutoGenerateColumns = false;
            dataGridViewBuildings.DataSource = buildingResource.GetBuildings();
        }

    }
}
