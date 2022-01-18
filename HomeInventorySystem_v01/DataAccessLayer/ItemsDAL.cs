using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeInventorySystem_v01.Entities;

namespace HomeInventorySystem_v01.DataAccessLayer
{
    public static class ItemsDAL
    {
        private static string connectionString = "Data Source =localhost; " +
            "Initial Catalog = PersonalShopping; Integrated Security = True";

        private static readonly SqlConnection connection = new SqlConnection(connectionString);

        public static void CreateItem(Item item)
        {
            string commandText = $"Insert into Items values('{item.ItemName}', '{item.Unit}'," +
                $" {item.Quantity}, {item.UserId} )";

            SqlCommand command = new SqlCommand(commandText, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateItem(Item item)
        {
            string commandText = $"Update Items Set " +
                $"ItemName = '{item.ItemName}', " +
                $"Unit = '{item.Unit}', " +
                $"Quantity = {item.Quantity}, " +
                $"UserId = {item.UserId} " +
                $"where ItemId = {item.ItemId}";

            SqlCommand command = new SqlCommand(commandText, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteItem(Item item)
        {
            string commandText = $"Delete from Items where ItemId = {item.ItemId}";

            SqlCommand command = new SqlCommand(commandText, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetAllItems()
        {
            string commandText = $"Select * from Items";
            SqlCommand command = new SqlCommand(commandText, connection);

            SqlDataAdapter da = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public static Item GetItemById(int itemId)
        {
            Item item = new Item();

            string commandText = $"Select * from Items where ItemId={itemId}";
            SqlCommand command = new SqlCommand(commandText, connection);

            connection.Open();

            SqlDataReader itemReader = command.ExecuteReader();

            if (itemReader.HasRows)
            {
                while (itemReader.Read())
                {
                    item.ItemId = itemReader.GetInt32(0);
                    item.ItemName = itemReader.GetString(1);
                    item.Unit = itemReader.GetString(2);
                    item.Quantity = itemReader.GetDouble(3);
                    item.UserId = itemReader.GetInt32(4);
                }
            }

            connection.Close();
            return item;

        }
    }
}
