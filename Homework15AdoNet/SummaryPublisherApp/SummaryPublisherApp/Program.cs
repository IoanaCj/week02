using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SummaryPublisherApp
{
    class Program
    {
        static void Main(string[] args)
        {

            CountPublisherRows();
            TopPublishers();
            TotalBooksPerPublisher();
            TotalPricePerPublisherBooks();


            Console.ReadKey();
        }

        //Number of rows from the Publisher table (Execute scalar)
        private static void CountPublisherRows()
        {
            SqlConnection insertConnection = CreateConnection();

            if (insertConnection.State == ConnectionState.Closed)
            {
                insertConnection.Open();
            }

            using (insertConnection)
            {
                SqlCommand NumberOfRows = new SqlCommand(@"select count(*) from Publisher", insertConnection);
                int count = (int)NumberOfRows.ExecuteScalar();
                Console.WriteLine($"The number of rows for publisher is: {count}");
            }

        }

        //Top 3 publishers (Id, Name) (SQL Data Reader)

        private static void TopPublishers()
        {
            SqlConnection insertConnection = CreateConnection();

            if (insertConnection.State == ConnectionState.Closed)
            {
                insertConnection.Open();
            }

            using (insertConnection)
            {
                SqlCommand command = new SqlCommand( "SELECT * FROM Publisher WHERE PublisherId BETWEEN '1' AND '3' ", insertConnection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string publisher = $"{reader["PublisherId"]} {reader["Name"]}";
                    Console.WriteLine($"Among the top 3 Publishers : {publisher}");

                }
            }
        }

        //Number of books for each publisher (Publiher Name, Number of Books)
        private static void TotalBooksPerPublisher()
        {
            SqlConnection insertConnection = CreateConnection();

            if (insertConnection.State == ConnectionState.Closed)
            {
                insertConnection.Open();
            }

            using (insertConnection)
            {
                SqlCommand booksPerPublisher = new SqlCommand("SELECT p.Name, COUNT(b.BookId) AS TotalBooksPerPublisher FROM Publisher p INNER JOIN Book b ON p.PublisherId = b.PublisherId GROUP BY p.Name", insertConnection);

                SqlDataReader reader = booksPerPublisher.ExecuteReader();

                while (reader.Read())
                {
                    string totalBooks = $"From {reader[0]} - {reader[1]} books";
                    Console.WriteLine(totalBooks);


                }
            }
        }

        //The total price for books for a publisher
        private static void TotalPricePerPublisherBooks()
        {
            SqlConnection insertConnection = CreateConnection();

            if (insertConnection.State == ConnectionState.Closed)
            {
                insertConnection.Open();
            }

            using (insertConnection)
            {
                SqlCommand totalPrice = new SqlCommand("SELECT p.Name, SUM(Price) AS TotalPrice FROM Book b LEFT JOIN Publisher p ON p.PublisherId = b.PublisherID GROUP BY p.Name; ", insertConnection);

                SqlDataReader reader = totalPrice.ExecuteReader();

                while (reader.Read())
                {
                    string totalPriceOfPublisherBooks = $" {reader[0]} - {reader[1]} ";
                    Console.WriteLine(totalPriceOfPublisherBooks);


                }
            }
        }
        private static SqlConnection CreateConnection()
        {
            string connectionString = "Data Source=.;Initial Catalog=BookPublisher;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
