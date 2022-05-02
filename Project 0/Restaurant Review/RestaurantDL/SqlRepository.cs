using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace RestaurantDL
{
    public class SqlRepository : IRepository
    {
        readonly string connectionString;

        public SqlRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void ListRestaurant()
        {
            string commandString = "SELECT * FROM Restaurant;";

            // the connection (SqlConnection): represents a connection to a database.
            // needs a connection string to know how to connect and where the database is.
            // can Open and Close the connection. is IDisposable so you can have it automatically
            // close with the help of a using statement.
            using SqlConnection connection = new(connectionString);
            // the command (SqlCommand): encapsulates some SQL commands to send.
            //  it supports using SqlParameters for protecting from SQL injection.
            using IDbCommand command = new SqlCommand(commandString, connection);
            connection.Open();
            // the data reader (SqlDataReader): represents a response to a SqlCommand
            // having 1 or more result sets (because of 1 or more SELECT statements).
            // the data reader provides each row of the data immediately as it's
            // received over the network.
            using IDataReader reader = command.ExecuteReader();

            // TODO: leaving out the abilities for now
       
            // reader.Read advances the "cursor" to the next row
            // and returns true if it's not at the end of the data.
            while (reader.Read())
            {
                // different ways to access the data in the current row
                // - reader[columnName]
                //      the return type of this is object. probably need to cast the type.
                // - reader.Get_____(columnIndex)
                //      return type is whatever type you asked for
                // be aware of DBNull
                Console.WriteLine();
            }
            
        }
    }


   
}
