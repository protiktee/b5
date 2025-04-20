using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory_b5.Models
{
    public class BaseEquipment
    {
        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public int Quantity { get; set; }
        public int Stock { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReceiveDate { get; set; }
        public List<BaseEquipment> ListEquipment()
        {
            List<BaseEquipment> listEquipment = new List<BaseEquipment>();
             
            string Connstring = ConfigurationManager.ConnectionStrings["Connstring"].ToString();  
            SqlConnection sqlConnection = new SqlConnection(Connstring);
            sqlConnection.Open();

            string CommandText = "spOST_LstEquipment";
            SqlCommand cmd = new SqlCommand(CommandText, sqlConnection);
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            // cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    BaseEquipment objBaseEquipment = new BaseEquipment();
                    objBaseEquipment.EquipmentId =Convert.ToInt32( reader["EquipmentId"].ToString());
                    objBaseEquipment.EquipmentName = reader["EquipmentName"].ToString();
                    objBaseEquipment.Quantity = Convert.ToInt32(reader["Quantity"].ToString());
                    objBaseEquipment.Stock = Convert.ToInt32(reader["Stock"].ToString());
                    objBaseEquipment.EntryDate = Convert.ToDateTime(String.IsNullOrEmpty(reader["EntryDate"].ToString()) ? "1900-01-01" : reader["EntryDate"].ToString()); 
                    objBaseEquipment.ReceiveDate = Convert.ToDateTime(String.IsNullOrEmpty(reader["ReceiveDate"].ToString()) ? "1900-01-01" : reader["ReceiveDate"].ToString());
                    listEquipment.Add(objBaseEquipment);
                }
            } 
            cmd.Dispose();
            sqlConnection.Close();
            return listEquipment;
        }

        public int SaveEquipment()
        {  
            string Connstring = ConfigurationManager.ConnectionStrings["Connstring"].ToString();
            SqlConnection sqlConnection = new SqlConnection(Connstring);
            sqlConnection.Open();

            string CommandText = "spOST_InsEquipment";
            SqlCommand cmd = new SqlCommand(CommandText, sqlConnection);
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SqlParameter("@EquipmentId", this.EquipmentName));
            cmd.Parameters.Add(new SqlParameter("@Name", this.EquipmentName));
            cmd.Parameters.Add(new SqlParameter("@EcCount", this.Quantity));
            cmd.Parameters.Add(new SqlParameter("@EntryDate", this.EntryDate));
            cmd.Parameters.Add(new SqlParameter("@ReceiveDate", this.ReceiveDate));
            //cmd.Parameters.Add()
            int returnvalue=cmd.ExecuteNonQuery(); 
            cmd.Dispose();
            sqlConnection.Close();
            return returnvalue ;
        }
        public DataTable ListAssignedEquipment()
        {
            DataTable dataTable = new DataTable();

            string Connstring = ConfigurationManager.ConnectionStrings["Connstring"].ToString();
            SqlConnection sqlConnection = new SqlConnection(Connstring);
            sqlConnection.Open();

            string CommandText = "spOst_LstCustomerEquiAssignment";
            SqlCommand cmd = new SqlCommand(CommandText, sqlConnection);
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            // cmd.ExecuteNonQuery();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            cmd.Dispose();
            sqlConnection.Close();
            return dataTable;
        }

        public static int SaveEquipmentAssignment(FormCollection frmCol)
        {
            string Connstring = ConfigurationManager.ConnectionStrings["Connstring"].ToString();
            SqlConnection sqlConnection = new SqlConnection(Connstring);
            sqlConnection.Open();

            string CommandText = "spOST_InsEquiAssignment";
            SqlCommand cmd = new SqlCommand(CommandText, sqlConnection);
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SqlParameter("@CustomerID", Convert.ToInt32(frmCol["txtCustomerID"].ToString())));
            cmd.Parameters.Add(new SqlParameter("@EquipmentID", Convert.ToInt32(frmCol["txtEquipmentID"].ToString())));
            cmd.Parameters.Add(new SqlParameter("@EquiCount", Convert.ToInt32(frmCol["txtQuantity"].ToString()))); 
            //cmd.Parameters.Add()
            int returnvalue = cmd.ExecuteNonQuery();
            cmd.Dispose();
            sqlConnection.Close();
            return returnvalue;
        }
    }
}