using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class CustomerManeger
    {
        
        
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + "Kaydınız Yapılmıştır!");
            
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + "Kaydınız Silinmiştir!");
            
        }
    
        
    }
}
