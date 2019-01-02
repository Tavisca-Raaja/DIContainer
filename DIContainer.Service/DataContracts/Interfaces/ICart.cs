using DIContainer.Service.DataContracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIContainer.Service.DataContracts.Interfaces
{
    public interface ICart
    {
        void AddProduct(AddCart request);
        void RemoveProduct();
        void UpdateCart();

    }
}
