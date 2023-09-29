using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P418_HW_29._09._23_Practical
{
    internal class Employee
    {
        public string fullName;
        public int age;
        public string address = "XXX";

        public string GetFullData()
        {
            return $"{fullName} - {age} - {address}";
        }
    }
}
