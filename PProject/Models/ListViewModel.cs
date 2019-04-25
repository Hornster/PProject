using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PProject.Models
{
    public class ListViewModel<T>
    {
        public List<T> Items { get; set; }
    }
}