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

        public void InsertContactInAddressBookTable()
        {
            var SQL = @$"insert into AddressBook Values  ('Siddhant','Shrivastava','A colony','Ujjain','MP',666666,9998889998,'Sid@gmail.com'),
                                                         ('Riya','Sharma','Ab colony','Lucknow','UP',677666,9998882348,'Riya@gmail.com'),
                                                         ('Pranav','Vyas','C colony','Pune','Maharashtra',656666,9923489998,'Pranav@gmail.com'),
                                                         ('Anamika','Singh','D colony','Chennai','Tamil Naidu',662226,8898889998,'Anamika@gmail.com');";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();
            int reader = cmd.ExecuteNonQuery();
            Console.WriteLine(reader);
            Console.WriteLine("Command Completed Successfully");
            Console.ReadKey();
            connection.Close();
        }

    }
}
