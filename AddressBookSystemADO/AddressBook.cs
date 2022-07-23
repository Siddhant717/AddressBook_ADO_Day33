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
        public void CreateAddressBookServiceDB()
        {
            //creating AddressBookService Database
            string SQL = "create database Address_Book_Service ";

            string connectingstring = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectingstring);
            SqlCommand sqlcommand = new SqlCommand(SQL, connection);
            try
            {
                connection.Open();
                sqlcommand.ExecuteNonQuery();
                Console.WriteLine("Database Created Successfully....");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception :" + e.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
