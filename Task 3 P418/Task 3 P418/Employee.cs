using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_P418
{
    internal class Employee
    {
        public int id;
        public string name;
        public string surname;
        public int age;
        public string address;
        public string email;
        public Employee[] Employees()
        {

            Employee employee1 = new Employee()
            {
                id = 1,
                name = "Person A",
                surname = "Surname A",
                age = 30,
                address = "Place 1",
                email = "persona.surnamea@gmail.com"
            };

            Employee employee2 = new Employee()
            {
                id = 2,
                name = "Person B",
                surname = "Surname B",
                age = 20,
                address = "Place 2",
                email = "personb.surnameb@gmail.com"
            };

            Employee employee3 = new Employee()
            {
                id = 3,
                name = "Person C",
                surname = "Surname C",
                age = 15,
                address = "Place 3",
                email = "personc.surnamec@gmail.com"
            };

            Employee[] employees = { employee1, employee2, employee3 };

            return employees;
        }
    }
}
