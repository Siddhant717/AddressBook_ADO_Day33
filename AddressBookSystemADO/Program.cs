using System;

namespace AddressBookSystemADO
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressbook = new();
           int result= addressbook.GetNumberOfPersonsCountbyType();
            Console.WriteLine("Total number of contacts available in Friend Type- "+ result);



        }
    }
}
