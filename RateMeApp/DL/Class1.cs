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

        string commandString = $"SELECT * FROM [{tableName}]";

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
        Console.WriteLine("------------------------------------------");
        //myTable.ForEach(x => x.ForEach(y => Console.WriteLine(y));

        // Console.WriteLine(commandString);

        return myTable;
    }


    static public void ShowTable(string connectionString, string tableName, string itemsToReveal)
    {

        string commandString = $"SELECT{itemsToReveal} FROM [{tableName}]";

        using SqlConnection connection = new(connectionString);
        connection.Open();
        using SqlCommand command = new(commandString, connection);
        Console.WriteLine(command);
        using SqlDataReader reader = command.ExecuteReader();




        /// List<Object> myTable;

        // List<Object> myTable = new List<Object>();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount - 1; i++)
                {
                    //users.Add(reader[i]);
                    Console.Write(reader[i] + "||");
                }
                //Console.WriteLine(reader);
                Console.WriteLine();
            }
        }
        //myTable.ForEach(x => Console.WriteLine(x));

        //Console.WriteLine(commandString);
        // return myTable;
    }

    static public void SearchTable(string connectionString, string tableName, string columnName, string searchItem)
    {

        string commandString = $"SELECT* FROM [{tableName}] WHERE [{columnName}] LIKE '{searchItem}%'";

        using SqlConnection connection = new(connectionString);
        connection.Open();
        using SqlCommand command = new(commandString, connection);
        //Console.WriteLine(command);
        using SqlDataReader reader = command.ExecuteReader();




        /// List<Object> myTable;

        // List<Object> myTable = new List<Object>();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount - 1; i++)
                {
                    //users.Add(reader[i]);
                    Console.Write(reader[i] + "||");
                }
                //Console.WriteLine(reader);
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------------------------------------------");
            }
        }
        //myTable.ForEach(x => Console.WriteLine(x));

        //Console.WriteLine(commandString);
        // return myTable;
    }


    static public object VerifyUser(string connectionString, string password, string login)
    {
        string commandString = $"SELECT CASE WHEN EXISTS ( SELECT * FROM Users WHERE email = '{login}' AND password='{password}') THEN 'TRUE' ELSE 'FALSE' END";

        object value = new object();


        using SqlConnection connection = new(connectionString);
        connection.Open();
        using SqlCommand command = new(commandString, connection);
        //Console.WriteLine(command);
        using SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                value = reader[0];

                //Console.WriteLine(reader);
                Console.WriteLine();
            }
        }

        return value;

    }

    static public object VerifyAdmin(string connectionString, string password, string login)
    {
        string commandString = $"SELECT CASE WHEN EXISTS ( SELECT * FROM Users WHERE email = '{login}' AND password='{password}' AND admin = 0) THEN 'TRUE' ELSE 'FALSE' END";

        object value = new object();


        using SqlConnection connection = new(connectionString);
        connection.Open();
        using SqlCommand command = new(commandString, connection);
        //Console.WriteLine(command);
        using SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                value = reader[0];

                //Console.WriteLine(reader);
                Console.WriteLine(value);
            }
        }

        return value;

    }

    static public void AddUser(string connectionString,string firstName, string lastName, string email, string phone, string password )
    {
        string commandString = $"Insert into users ([first name], [last name], [email], [phone], [password], [admin]) Values ('{firstName}', '{lastName}', '{email}', '{phone}', '{password}', 1)";

        object value = new object();


        using SqlConnection connection = new(connectionString);
        connection.Open();
        using SqlCommand command = new(commandString, connection);
        //Console.WriteLine(command);
        using SqlDataReader reader = command.ExecuteReader();
    }



}
    /*
    static public void AddReview(string connectionString, string name, string address, string searchItem)
    {

        string commandString = $"INSERT INTO Review ([Name], [Address], [City],[State], [Zip], [Country], [Phone],[Email], [Website]) VALUES('Happy Lamb Hot Pot', '240 Legacy Dr #116', 'Plano', 'TX', '75023', 'USA', '9725758887', 'https://client.minitable.net/c_reservation?sid=sf3ad5ceda60b906f67c05387e759ce1c')";

        using SqlConnection connection = new(connectionString);
        connection.Open();
        using SqlCommand command = new(commandString, connection);
        Console.WriteLine(command);
        using SqlDataReader reader = command.ExecuteReader();


    }

    */
