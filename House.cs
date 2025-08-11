using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._1._1
{
    public class House
    {
        public int number;
        public string? address;
        public HouseType houseType;
        public House? next;

        public override string ToString()
        {
            return $"{number} {address} ({houseType})";
        }
    }
}
