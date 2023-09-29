//using P418_HW_29._09._23_Practical;
//using System.Data.Common;

//Employee employee1 = new()
//{
//    fullName = "Name A",
//    age = 23,
//    address = "Location A"
//};

//Employee employee2 = new()
//{
//    fullName = "Name B",
//    age = 22,
//    address = "Location B"
//};

//Employee employee3 = new()
//{
//    fullName = "Name C",
//    age = 24,
//    address = "Location C"
//};

//Employee[] emplyees = { employee1, employee2, employee3};

//foreach (var employee in emplyees)
//{
//    Console.WriteLine(employee.GetFullData);
//}



// -------------------------------------------------------------------------



//using P418_HW_29._09._23_Practical;

//Book book = new Book("Deception Point", "Dan Brown");

//book.num = 56;
//book.name = "Deception Point";
//book.author = "Dan Brown";

//Console.WriteLine(book.GetData());

//Book book = new Book(100, "AZ");



// -------------------------------------------------------------------------


using P418_HW_29._09._23_Practical;
using P418_HW_29._09._23_Practical.Models;

//static Users[] GetAllUsers()
//{

//    Users user1 = new Users()
//    {
//        id = 1,
//        fullName = "Person A",
//        age = 18
//    };

//    Users user2 = new Users()
//    {
//        id = 2,
//        fullName = "Person B",
//        age = 19
//    };

//    Users user3 = new Users()
//    {
//        id = 3,
//        fullName = "Person C",
//        age = 20
//    };

//    Users[] people = { user1, user2, user3 };

//    return people;

//}

//static void ShowUsers()
//{
//    var result = GetAllUsers();

//    foreach (var user in result)
//    {
//        Console.WriteLine(user.fullName);
//    }
//}

//foreach (Users user in people)
//{
//    //Console.WriteLine(user.fullName);
//    if(user.id == 2)
//    {
//        Console.WriteLine(user.fullName);
//    }
//}

//var reuslt = people.FirstOrDefault(m => m.id > 2);

//Console.WriteLine(reuslt.fullName);

//var result = Array.FindAll(people,m => m.age > 20);

//foreach(var item in result)
//{
//    Console.WriteLine(item.fullName);
//}

//var result = GetAllUsers();

//ShowUsers();



// -------------------------------------------------------------------




//UserService service = new();

//service.ShowUsers();

//service.GetUserById(3);

//Users users = service.GetUserById(1);

//Console.WriteLine(users.fullName);



// ---------------------------------------------------------------


//static void SearchByName(string searchText)
//{
//    Product[] products = GetAllProducts();

//    Product existProduct = products.FirstOrDefault(m => m.name.Trim().ToLower().Contains(searchText.ToLower().Trim()));


//    if(existProduct == null)
//    {
//        Console.WriteLine("NotFound");
//        return;
//    }

//    Product[] resultProducts = products.Where(m => m.name.Trim().ToLower().Contains(searchText.ToLower().Trim())).ToArray();

//    //foreach (var product in products)
//    //{
//    //    if (product.name.Trim().ToLower().Contains(searchText.ToLower().Trim()))
//    //    { 
//    //        Console.WriteLine($"{product.id} - {product.name} - {product.price} - {product.count}");
//    //    }
//        //else
//        //{
//        //    Console.WriteLine("Not found");
//        //}
//    }
//}

//Console.WriteLine("Add search text:");

//SearchText: string searchText = Console.ReadLine();

//SearchByName(searchText);

//if (searchText == "")
//{
//    Console.WriteLine("Please add search text!");
//    goto SearchText;
//}

//static Product[] GetAllProducts()
//{
//    Product product1 = new Product
//    {
//        id = 1,
//        name = "Iphone 13",
//        price = 22000,
//        count = 3
//    };

//    Product product2 = new Product
//    {
//        id = 2,
//        name = "Samsung S24",
//        price = 12000,
//        count = 5
//    };

//    Product product3 = new Product
//    {
//        id = 3,
//        name = "Xiamo",
//        price = 9000,
//        count = 20
//    };

//    Product[] products = {product1, product2, product3 };

//    return products;
//}