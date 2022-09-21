using ClassMethodDemo;

Customer customer1 = new Customer();
customer1.Id = "2103021601";
customer1.FirstName = "Kaan";
customer1.LastName = "Yıldırım";

Customer customer2 = new Customer();
customer2.Id = "2103021602";
customer2.FirstName = "Engin";
customer2.LastName = "Demiroğ";

Customer[] customers = new Customer[] { customer1, customer2 };

CustomerManeger maneger1 = new CustomerManeger();
maneger1.AddCustomer(customer1);
maneger1.AddCustomer(customer2);
Console.WriteLine("----------------------------");
maneger1.DeleteCustomer(customer1);
maneger1.DeleteCustomer(customer2);
Console.WriteLine("----------------------------");
foreach (Customer customer in customers)
{
    Console.WriteLine(customer.Id + " " + customer.FirstName + " " + customer.LastName);
}







