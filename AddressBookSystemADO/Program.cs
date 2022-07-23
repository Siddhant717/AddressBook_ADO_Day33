using System;

namespace AddressBookSystemADO
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressbook = new();
            addressbook.CreateAddressBookServiceDB();

        }
    }
}
