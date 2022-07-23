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
        //Updating existing contacts in AddressBook table
        public void UpdateExistingContactInAddressBookTable()
        {
            var SQL = @$"update AddressBook set Address = 'Sai Colony', City = 'Indore' where FirstName = 'Siddhant'";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();
            int reader = cmd.ExecuteNonQuery();
            Console.WriteLine(reader);
            Console.WriteLine("Commands Completed SuccessFully");
            Console.ReadKey();
            connection.Close();
        }
    }
}
