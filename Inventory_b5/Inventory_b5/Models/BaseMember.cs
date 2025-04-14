using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Inventory_b5.Models
{
    public class BaseMember
    {

        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string ServiceType { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string DashBoardPageURL { get; set; }

        public DataTable ValidateMemberAsDataTable(string UserName, string password)
        {
            DataTable dataTable = new DataTable();  

            //Connectionstring
            string Connstring=ConfigurationManager.ConnectionStrings["Connstring"].ToString();
            //Appsetting
            //string Connstring = ConfigurationManager.AppSettings["ConnstringAppSetting"].ToString();

            SqlConnection sqlConnection = new SqlConnection(Connstring);
            sqlConnection.Open();

            string CommandText = "select * from OSTMember where Name='"+ UserName + "' and Password='"+ password + "'";
            SqlCommand cmd = new SqlCommand(CommandText, sqlConnection);
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();

            //table data
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            cmd.Dispose();
            sqlConnection.Close();
            return dataTable; 
        }
        public DataTable ValidateMemberAsDataTableBySP(string UserName, string password)
        {
            DataTable dataTable = new DataTable();

            //Connectionstring
            string Connstring = ConfigurationManager.ConnectionStrings["Connstring"].ToString();
            //Appsetting
            //string Connstring = ConfigurationManager.AppSettings["ConnstringAppSetting"].ToString();

            SqlConnection sqlConnection = new SqlConnection(Connstring);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spOst_LstMember";
            cmd.Connection = sqlConnection;
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SqlParameter("@UserName", UserName));
            cmd.Parameters.Add(new SqlParameter("@Password", password));
            //table data
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            cmd.Dispose();
            sqlConnection.Close();
            return dataTable;
        }
        public List<BaseMember> ValidateMemberAsList(string UserName, string password)
        { 
            List<BaseMember> listMember = new List<BaseMember>(); 

            //Connectionstring
            string Connstring = ConfigurationManager.ConnectionStrings["Connstring"].ToString();
            //Appsetting
            //string Connstring = ConfigurationManager.AppSettings["ConnstringAppSetting"].ToString();

            SqlConnection sqlConnection = new SqlConnection(Connstring);
            sqlConnection.Open();

            string CommandText = "select * from OSTMember";
            SqlCommand cmd = new SqlCommand(CommandText, sqlConnection);
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear(); 
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    BaseMember objMember = new BaseMember();
                    objMember.Name = reader["Name"].ToString();
                    objMember.Password = reader["Password"].ToString();
                    objMember.id =Convert.ToInt16( reader["id"].ToString());
                    objMember.Age = Convert.ToInt16(reader["Age"].ToString());
                    objMember.ServiceType = reader["ServiceType"].ToString();
                    listMember.Add(objMember);
                }
            }


            cmd.Dispose();
            sqlConnection.Close();
            return listMember;
        }
    }
}