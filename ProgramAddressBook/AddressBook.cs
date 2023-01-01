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
        public void Addbook()//UC1
        {

            Contacts contacts1 = new Contacts();
            Console.WriteLine("Enter The FirstName");
            contacts1.FirstName = Console.ReadLine();
            Console.WriteLine("Enter The LastName");
            contacts1.LastName = Console.ReadLine();
            Console.WriteLine("Enter The Address");
            contacts1.Address = Console.ReadLine();
            Console.WriteLine("Enter The City");
            contacts1.City = Console.ReadLine();
            Console.WriteLine("Enter The State");
            contacts1.State = Console.ReadLine();
            Console.WriteLine("Enter The Zipcode");
            contacts1.ZipCode = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter The MobileNo");
            contacts1.MobNo = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Email_ID");
            contacts1.Email = Console.ReadLine();

            add.Add(contacts1);

        }
        public void Display()//UC2
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
                Console.WriteLine("Email_Id:" + data.Email);

            }
        }
        public void UpdateList()//UC3
        {
            foreach (var data in add)
            {
                //Console.WriteLine("Enter to first name for update");
                string first_Name = Console.ReadLine();

                if (add.Contains(data))
                {
                    Console.WriteLine("1.First_Name\n2.Last_Name\n3.Address\n4.City\n5.State\n6.Zip Code\n7.Phone Number\n8.Email");
                    Console.WriteLine("Choose Your Option");
                    int Option = Convert.ToInt32(Console.ReadLine());

                    switch (Option)
                    {
                        case 1:
                            string first_name = Console.ReadLine();
                            data.FirstName = first_name;
                            break;
                        case 2:
                            string last_Name = Console.ReadLine();
                            data.LastName = last_Name;
                            break;
                        case 3:
                            string address = Console.ReadLine();
                            data.Address = address;
                            break;
                        case 4:
                            string city = Console.ReadLine();
                            data.City = city;
                            break;
                        case 5:
                            string state = Console.ReadLine();
                            data.State = state;
                            break;
                        case 6:
                            long zipcode = long.Parse(Console.ReadLine());
                            data.ZipCode = zipcode;
                            break;
                        case 7:
                            long phonenumber = long.Parse(Console.ReadLine());
                            data.MobNo = phonenumber;
                            break;
                        case 8:
                            string Email_ID = Console.ReadLine();
                            data.Email = Email_ID;
                            break;

                    }
                    Console.WriteLine("First_Name: {0}\nLast_Time: {1}\nAddress: {2}\nCity: {3}\nState: {4}\nZip Code: {5}\nPhone Number: {6}\nEmail: {7}", data.FirstName, data.LastName, data.Address, data.City, data.State, data.ZipCode, data.MobNo, data.Email);
                    break;
                }

            }
        }
    }
}
