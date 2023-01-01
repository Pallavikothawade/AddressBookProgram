using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAddressBook
{
    internal class AddressBook
    {
        List<Contacts> add = new List<Contacts>();
        public void Addbook()
        {
            
            Contacts contacts1 = new Contacts();
            Console.WriteLine("Enter The FirstName");
            contacts1.FirstName = Console.ReadLine();
            Console.WriteLine("Enter The LastName");
            contacts1.LastName = Console.ReadLine();
            Console.WriteLine("Enter The Address");
            contacts1.Address= Console.ReadLine();
            Console.WriteLine("Enter The City");
            contacts1.City = Console.ReadLine();
            Console.WriteLine("Enter The State");
            contacts1.State = Console.ReadLine();
            Console.WriteLine("Enter The Zipcode");
            contacts1.ZipCode = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter The MobileNo");
            contacts1.MobNo =long.Parse( Console.ReadLine());

            add.Add(contacts1);

        }
        public void Display()
        {
            foreach (Contacts data in add)
            {
                Console.WriteLine("Firstname:" + data.FirstName);
                Console.WriteLine("Lastname:" + data.LastName);
                Console.WriteLine("Address:" + data.Address);
                Console.WriteLine("city:" + data.City);
                Console.WriteLine("state:" + data.State);
                Console.WriteLine("Zipcode:" + data.ZipCode);
                Console.WriteLine("PhoneNumber:" + data.MobNo);

            }
        }
        public void UpdateList()
        {

        }
    }
}
