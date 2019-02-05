using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InsertPublisherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            InsertPublisher("Libris");

            //2. With this console read the name of publisher
            PrintPublishers();

            Console.ReadKey();
        }

        private static void PrintPublishers()
        {
            SqlConnection conn = CreateConnection();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            using (conn)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT * FROM Publisher", conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string publisher = $"{reader["PublisherId"]} {reader["Name"]}";
                    Console.WriteLine(publisher);

                }
            }
        }

        private static void InsertPublisher(string publisherName)
        {
            SqlConnection insertConnection = CreateConnection();

            if (insertConnection.State == ConnectionState.Closed)
            {
                insertConnection.Open();
            }

            using (insertConnection)
            {
                var cmd = insertConnection.CreateCommand();
                cmd.CommandText = "INSERT INTO Publisher (Name) values (@name)";
                cmd.Parameters.AddWithValue("name", publisherName);
                cmd.ExecuteNonQuery();
            }

          

            //try
            //{
            //    var cmd = insertConnection.CreateCommand();
            //    cmd.CommandText = "INSERT INTO Publisher (Name) values (@name)";
            //    cmd.Parameters.AddWithValue("name", publisherName);
            //    cmd.ExecuteNonQuery();
            //}
            //finally
            //{
            //    insertConnection.Dispose();
            //}



        }

        private static SqlConnection CreateConnection()
        {
            string connectionString = "Data Source=.;Initial Catalog=BookPublisher;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}

