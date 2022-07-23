using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemADO
{
    public class AddressBook
    {

        //Creating AddressBook Table
        public void CreateAddressBookTable()
        {
            var SQL = @$"create table AddressBook ( FirstName Varchar(20), LastName Varchar(20), Address Varchar(50), City Varchar(20), State Varchar(20), ZipCode int, PhoneNumber bigint, Email Varchar(20) )";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();
            int reader = cmd.ExecuteNonQuery();
            Console.WriteLine(reader);
            Console.WriteLine("AddressBook Table Created Successfully");
            Console.ReadKey();
            connection.Close();
        }
    }
}
