using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P418_HW_29._09._23_Practical.Models;

namespace P418_HW_29._09._23_Practical
{
    internal class UserService
    {
        public Users[] GetAllUsers()
        {

            Users user1 = new Users()
            {
                id = 1,
                fullName = "Person A",
                age = 18
            };

            Users user2 = new Users()
            {
                id = 2,
                fullName = "Person B",
                age = 19
            };

            Users user3 = new Users()
            {
                id = 3,
                fullName = "Person C",
                age = 20
            };

            Users[] people = { user1, user2, user3 };

            return people;

        }

        public void ShowUsers()
        {
            var result = GetAllUsers();

            foreach (var user in result)
            {
                Console.WriteLine(user.fullName);
            }
        }

        public Users GetUserById(int id)
        {
            Users[] users = GetAllUsers();

            Users user = users.FirstOrDefault(m => m.id == id);

            return user;
        }
    }
}
 