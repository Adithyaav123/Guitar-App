using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    internal class Guitar
    {
        private string serialNumber;
        private double price;
        private GuitarSpec spec;

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }

        public string GetSerialNumber()
        {
            return serialNumber;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double newPrice)
        {
            this.price = newPrice;
        }

        public GuitarSpec GetSpec()
        {
            return spec;
        }
    }
}
