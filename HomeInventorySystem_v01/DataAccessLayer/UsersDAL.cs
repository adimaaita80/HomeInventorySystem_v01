using HomeInventorySystem_v01.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeInventorySystem_v01.DataAccessLayer
{
    public static class UsersDAL
    {
        private static string connectionString = "Data Source =localhost; " +
            "Initial Catalog = PersonalShopping; Integrated Security = True";

        private static readonly SqlConnection connection = new SqlConnection(connectionString);

        public static void CreateUser(User user)
        {
            string commandText = $"Insert into SystemUsers values('{user.FirstName}', '{user.LastName}'," +
                $" '{user.Username}', '{user.Password}' )";

            SqlCommand command = new SqlCommand(commandText, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateUser(User user)
        {
            string commandText = $"Update SystemUsers Set " +
                $"FirstName = '{user.FirstName}'" +
                $"LastName = '{user.LastName}'" +
                $"Username = '{user.Username}'" +
                $"Password = '{user.Password}'";

            SqlCommand command = new SqlCommand(commandText, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteUser(User user)
        {
            string commandText = $"Delete from SystemUsers where UserId = {user.UserId}";

            SqlCommand command = new SqlCommand(commandText, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetAllUsers()
        {
            string commandText = $"Select * from SystemUsers";
            SqlCommand command = new SqlCommand(commandText, connection);

            SqlDataAdapter da = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public static User GetUserById(int userId)
        {
            User user = new User();

            string commandText = $"Select * from SystemUsers where UserId={userId}";
            SqlCommand command = new SqlCommand(commandText, connection);

            SqlDataReader userReader = command.ExecuteReader();

            connection.Open();

            if(userReader.HasRows)
            {
                while (userReader.Read())
                {
                    user.UserId = userReader.GetInt32(0);
                    user.FirstName = userReader.GetString(1);
                    user.LastName = userReader.GetString(2);
                    user.Username = userReader.GetString(3);
                    user.Password = userReader.GetString(4);
                }
            }

            connection.Close();
            return user;
            
        }
    }
}
