using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class Address
    {
        private string street;
        private string city;

        public Address(string street, string city)
        {
            this.street = street;
            this.city = city;
        }

        public string DisplayStat()
        {
            return string.Format("Street: {0}; " +
                "City: {1}",this.street,this.city);
        }
    }
}
