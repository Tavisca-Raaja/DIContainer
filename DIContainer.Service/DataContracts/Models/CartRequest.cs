using System;
using System.Collections.Generic;
using System.Text;

namespace DIContainer.Service.DataContracts.Models
{
    public class AddCart
    {
        public string ProductName{ get; set; }
        public string ProductId { get; set; }
        public string ProductQuantity { get; set; }
    }
}
