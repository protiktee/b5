using Microsoft.Data.SqlClient;
using System.Data;

namespace QAndA_b5.Model
{
    //public interface IConfiguration _configuration { get; set; }
    public class DBConnection
    {
        public static IConfiguration _configuration { get; set; }
        public string GetConnectionString()
        {
            string Connstring = "";
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            _configuration= builder.Build();
            return _configuration["ConnectionStrings:OST"].ToString();
        }

        public DataTable GetData()
        {
            DataTable dataTable = new DataTable();

            string ConnString = GetConnectionString();
            SqlConnection sqlConnection = new SqlConnection(ConnString);
            sqlConnection.Open();

            string CommandText = "spOST_LstEquipment";
            SqlCommand cmd = new SqlCommand(CommandText, sqlConnection);
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            // cmd.ExecuteNonQuery();
             
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);


            return dataTable;
        }
    }
}
