using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using RestaurantModels;



namespace RestaurantDL
{
    public class SqlRepository : IRepository
    {
        private const string connectionStringFilePath = "../RestaurantDl/Db-Connection-string-File.txt";
        private readonly string connectionString;

        public SqlRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<ReviewModel> ReviewsForRestaurantConnected()
        {
            string commandString = "SELECT * FROM Reviews;";

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
            var Reviews = new List<ReviewModel>();
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
                Reviews.Add(new ReviewModel
                {
                    ReviewID = reader.GetInt32(0),
                    RestaurantID = reader.GetInt32(1),
                    UserId = reader.GetInt32(2),
                    ReviewScore = reader.GetInt32(3)


                });
            }
            return Reviews;


        }

        public List<ReviewModel> GetAllReviews()
        {
            string commandString = "SELECT * FROM Reviews;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            connection.Open();
            adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.
            connection.Close();

            // TODO: leaving out the abilities for now
            var reviews = new List<ReviewModel>();
            DataColumn levelColumn = dataSet.Tables[0].Columns[2];
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                reviews.Add(new ReviewModel
                {
                    ReviewID = (int)row["ReviewID"],
                    RestaurantID = (int)row["RestaurantID"],
                    UserId = (int)row["UserID"],
                    ReviewScore = (int)row["Reviewscore"],
                });
            }
            return reviews;
        }

        public ReviewModel AddReview(ReviewModel review)
        {
            string commandString = "INSERT INTO Reviews (ReviewID, RestaurantID, UserID, Reviewscore) " +
                "VALUES (@ReviewID, @RestaurantID, @UserID, @Reviewscore);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@ReviewID", review.ReviewID);
            command.Parameters.AddWithValue("@RestaurantID", review.RestaurantID);
            command.Parameters.AddWithValue("@UserID", review.UserId);
            command.Parameters.AddWithValue("@Reviewscore", review.ReviewScore);

            connection.Open();
            command.ExecuteNonQuery();

            return review;
        }

    }

}
