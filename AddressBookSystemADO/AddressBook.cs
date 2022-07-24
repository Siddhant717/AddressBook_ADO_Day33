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
        // //Sort Persons Name Alphabetically for a given city
        public void GetAllContactsInAlphbeticalOrderByCity()
        {
            var SQL = @$"select * from AddressBook where City='Pune'order by FirstName asc";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service;Integrated Security=True"; ;
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("FirstName {0} - LastName {1} - Address {2} - City {3} -State {4} - ZipCode {5} - PhoneNumber {6} - Email {7} ", reader["FirstName"], reader["LastName"], reader["Address"],
                        reader["City"], reader["State"], reader["ZipCode"], reader["PhoneNumber"], reader["Email"]);
                }
                reader.Close();
            };
            Console.ReadKey();
        }
    }
    
        
        

}


