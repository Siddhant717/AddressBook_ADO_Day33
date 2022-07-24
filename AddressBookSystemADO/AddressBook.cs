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
        // Adding Type Column into table
        public void AddTypeColumn()
        {
            var SQL = @$"alter table  AddressBook add Type varchar(20)";


            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service;Integrated Security=True"; ;
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();
            int reader = cmd.ExecuteNonQuery();
            Console.WriteLine(reader);
            Console.WriteLine(" Type Column Added ");
            Console.ReadKey();
            connection.Close();
        }
        //Identify the address book by Name and Type
        public void UpdateAddressBookByNameandType()
        {
            var sql = $@"update AddressBook set Type ='Family' where FirstName = 'Siddhant'
                         update AddressBook set Type ='Friend'where FirstName = 'Riya'
                         update AddressBook set Type ='Friend'  where FirstName = 'Pranav'
                         update AddressBook set Type = 'Profession' where FirstName = 'Vikas'
                         update AddressBook set Type = 'Family' where FirstName = 'Shubham'
                         update AddressBook set Type = 'Profession' where FirstName = 'Rishabh'
                         update AddressBook set Type = 'Profession' where FirstName = 'Priya'";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service;Integrated Security=True"; ;
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int reader = cmd.ExecuteNonQuery();
            Console.WriteLine(reader);
            Console.WriteLine("AddressBook Table is Updated Successfully ");
            Console.ReadKey();
            connection.Close();
        }
    }

}








