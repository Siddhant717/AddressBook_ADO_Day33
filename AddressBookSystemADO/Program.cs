using System;

namespace AddressBookSystemADO
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressbook = new();
           int result1= addressbook.SizeOfAddressBookByCity();
            Console.WriteLine("Total City- "+result1);

            int result2 = addressbook.SizeOfAddressBookByState();
            Console.WriteLine("Total State- " + result2);



        }
    }
}
