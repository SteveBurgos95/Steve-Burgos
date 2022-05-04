using Microsoft.Data.SqlClient;
using System.Data; 

namespace DL;

public class SQLDataLogic
{
    
    static public string ConnectOpen(string connection)
    {

        string commandString = "SELECT * FROM Users";
        return connection;
    }


    // Method that takes in a connection string for a sql server a table name within
    // that sql server and returns a List<Object> with the List<Objects>
    static public List<Object> GetTable(string connectionString, string tableName)
    {

        string commandString = $"SELECT * FROM {tableName}";

        using SqlConnection connection = new(connectionString);
        connection.Open();
        using SqlCommand command = new(commandString, connection);

        using SqlDataReader reader = command.ExecuteReader();


        //List<Object> myTable;
        List<Object> myTable = new List<Object>();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                
                List<Object> users = new List<Object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                     users.Add(reader[i]);
                    Console.WriteLine(reader[i]);
                }
                myTable.Add(users);
            }
        }
        //myTable.ForEach(x => Console.WriteLine(x));

            Console.WriteLine(commandString);

        return myTable;
    }

    static public string SearchTable(string connectionString, string tableName, string columnName, string searchItem)
    {

        string commandString = $"SELECT * FROM {tableName}";

        using SqlConnection connection = new(connectionString);
        connection.Open();
        using SqlCommand command = new(commandString, connection);

        using SqlDataReader reader = command.ExecuteReader();


        //List<Object> myTable;
        List<Object> myTable = new List<Object>();

        if (reader.HasRows)
        {
            while (reader.Read())
            {

                List<Object> users = new List<Object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    users.Add(reader[i]);
                    Console.WriteLine(reader[i]);
                }
                myTable.Add(users);
            }
        }
        //myTable.ForEach(x => Console.WriteLine(x));

        Console.WriteLine(commandString);

        return searchItem;
    }

}


