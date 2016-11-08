using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabelManager.Models;

namespace LabelManager.ViewModels
{
    public class CustomerOrderViewModel
    {
        public Label Label { get; set; }
        public List<Customer> Customers { get; set; }
    }
}