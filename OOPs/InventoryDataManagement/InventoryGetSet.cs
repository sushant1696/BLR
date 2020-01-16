using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.InventoryDataManagement
{
    class InventoryGetSet
    {
       
            private string name;
        private double weight;
        private int price;

        public string Name { get => this.name; set => this.name = value; }
        public double Weight { get => this.weight; set => this.weight = value; }
        public int Price { get => this.price; set => this.price = value; }
    }
    
}
