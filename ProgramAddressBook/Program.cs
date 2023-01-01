using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook1 = new AddressBook();
            addressBook1.Addbook();
            addressBook1.Display();
             Console.ReadLine();
        }
    }
}
