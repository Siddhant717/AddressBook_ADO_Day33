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
        //Get number of contact persons i.e count by type
        public int GetNumberOfPersonsCountbyType()
        {
            var SQL = @$"select Count(*) from AddressBook where Type='Friend'";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service;Integrated Security=True";
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










