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
        //Retrieve the person belonging to City/State
        public int SizeOfAddressBookByCity()
        {
            var SQL = @$"select Count(City)  from AddressBook; ";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service;Integrated Security=True"; ;
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();
            object countbycity = cmd.ExecuteScalar();
            int Count = (int)countbycity;
            return Count;
            connection.Close();

        }
        //Size of Addressbook by State
        public int SizeOfAddressBookByState()
        {
            var SQL = @$"select Count(State) from AddressBook";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service;Integrated Security=True"; ;
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();
            object countbystate = cmd.ExecuteScalar();
            int Count = (int)countbystate;
            return Count;
            connection.Close();

        }
    }

}


