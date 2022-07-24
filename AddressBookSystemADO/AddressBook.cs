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
        //Add person to both Friend and Family
        public void AddPersonToBothFriendAndFamily()
        {
            var SQL = @$"insert into AddressBook values 
                      ('Kunal','Jain','CT colony','Bangalore','Karnataka',558866,7778889998,'Kunal@gmail.com','Friend'),
                      ('Saara','Khan','K colony','Bangalore','Karnataka',567466,7898882348,'Saara@gmail.com','Family')";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();
            int reader = cmd.ExecuteNonQuery();
            Console.WriteLine(reader);
            Console.WriteLine("Contact Person is Added Successfully ");
            Console.ReadKey();
            connection.Close();

        }

    }
}










