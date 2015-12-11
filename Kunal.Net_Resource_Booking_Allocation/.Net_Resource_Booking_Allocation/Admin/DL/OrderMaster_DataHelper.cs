using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Net_Resource_Booking_Allocation.Admin.DL
{
    public class OrderMaster_DataHelper
    {
        String strConnString = ConfigurationManager.ConnectionStrings["ResourceAllocationConnectionString1"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();

        public void UpdateProject(string Flag, int Prj_Id, string Prj_Client_Nam, string Prj_Name, string Prj_Details, string Prj_OnShore_EM_SDM, string Prj_OffShore_EM_SDM, string Prj_Status, DateTime Prj_Exp_StartDate, DateTime Prj_Exp_EndDate, string Prj_Effort, string Prj_FTE, int Prj_Revenue, decimal Prj_Contribution_Margin, decimal Prj_Expected_Rightshore_penetration, string Prj_Comments, int Prj_Active, int Prj_Del)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_OrderMaster";

            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 6).Value = Flag;
            cmd.Parameters.Add("@Prj_Id", SqlDbType.Int, 4).Value = Prj_Id;
            cmd.Parameters.Add("@Prj_Client_Nam", SqlDbType.NVarChar, 200).Value = Prj_Client_Nam;
            cmd.Parameters.Add("@Prj_Name", SqlDbType.NVarChar, 100).Value = Prj_Name;
            cmd.Parameters.Add("@Prj_Details", SqlDbType.NVarChar, 1000).Value = Prj_Details;
            cmd.Parameters.Add("@Prj_OnShore_EM_SDM", SqlDbType.NVarChar, 100).Value = Prj_OnShore_EM_SDM;
            cmd.Parameters.Add("@Prj_OffShore_EM_SDM", SqlDbType.NVarChar, 200).Value = Prj_OffShore_EM_SDM;
            cmd.Parameters.Add("@Prj_Status", SqlDbType.NVarChar, 200).Value = Prj_Status;
            cmd.Parameters.Add("@Prj_Exp_StartDate ", SqlDbType.DateTime, 10).Value = Prj_Exp_StartDate;
            cmd.Parameters.Add("@Prj_Exp_EndDate", SqlDbType.DateTime, 10).Value = Prj_Exp_EndDate;
            cmd.Parameters.Add("@Prj_Effort", SqlDbType.NVarChar, 300).Value = Prj_Effort;
            cmd.Parameters.Add("@Prj_FTE", SqlDbType.NVarChar, 100).Value = Prj_FTE;
            cmd.Parameters.Add("@Prj_Revenue", SqlDbType.Int, 4).Value = Prj_Revenue;
            cmd.Parameters.Add("@Prj_Contribution_Margin", SqlDbType.Decimal, 9).Value = Prj_Contribution_Margin;
            cmd.Parameters.Add("@Prj_Expected_Rightshore_penetration", SqlDbType.Decimal, 9).Value = Prj_Expected_Rightshore_penetration;
            cmd.Parameters.Add("@Prj_Comments", SqlDbType.NVarChar, 4000).Value = Prj_Comments;
            cmd.Parameters.Add("@Prj_Active", SqlDbType.SmallInt, 1).Value = Prj_Active;
            cmd.Parameters.Add("@Prj_Del", SqlDbType.SmallInt, 1).Value = Prj_Del;

            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable EditProject(int Prj_Id, string Flag)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_OrderMaster";
            cmd.Parameters.Add("@Prj_Id", SqlDbType.Int, 4).Value = Prj_Id;
            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 6).Value = Flag;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable EditProject()
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_OrderMasterdisplay";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void AddProject(string Flag, string Prj_Client_Nam, string Prj_Name, string Prj_Details, string Prj_OnShore_EM_SDM, string Prj_OffShore_EM_SDM, string Prj_Status, DateTime Prj_Exp_StartDate, DateTime Prj_Exp_EndDate, string Prj_Effort, string Prj_FTE, int Prj_Revenue, decimal Prj_Contribution_Margin, decimal Prj_Expected_Rightshore_penetration, string Prj_Comments, int Prj_Active, int Prj_Del)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_OrderMaster";
            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 6).Value = Flag;
            cmd.Parameters.Add("@Prj_Client_Nam", SqlDbType.NVarChar, 200).Value = Prj_Client_Nam;
            cmd.Parameters.Add("@Prj_Name", SqlDbType.NVarChar, 100).Value = Prj_Name;
            cmd.Parameters.Add("@Prj_Details", SqlDbType.NVarChar, 1000).Value = Prj_Details;
            cmd.Parameters.Add("@Prj_OnShore_EM_SDM", SqlDbType.NVarChar, 100).Value = Prj_OnShore_EM_SDM;
            cmd.Parameters.Add("@Prj_OffShore_EM_SDM", SqlDbType.NVarChar, 200).Value = Prj_OffShore_EM_SDM;
            cmd.Parameters.Add("@Prj_Status", SqlDbType.NVarChar, 200).Value = Prj_Status;

            cmd.Parameters.Add("@Prj_Exp_StartDate ", SqlDbType.DateTime, 10).Value = Prj_Exp_StartDate;
            cmd.Parameters.Add("@Prj_Exp_EndDate", SqlDbType.DateTime, 10).Value = Prj_Exp_EndDate;
            cmd.Parameters.Add("@Prj_Effort", SqlDbType.NVarChar, 300).Value = Prj_Effort;
            cmd.Parameters.Add("@Prj_FTE", SqlDbType.NVarChar, 100).Value = Prj_FTE;
            cmd.Parameters.Add("@Prj_Revenue", SqlDbType.Int, 4).Value = Prj_Revenue;
            cmd.Parameters.Add("@Prj_Contribution_Margin", SqlDbType.Decimal, 9).Value = Prj_Contribution_Margin;
            cmd.Parameters.Add("@Prj_Expected_Rightshore_penetration", SqlDbType.Decimal, 9).Value = Prj_Expected_Rightshore_penetration;
            cmd.Parameters.Add("@Prj_Comments", SqlDbType.NVarChar, 4000).Value = Prj_Comments;
            cmd.Parameters.Add("@Prj_Active", SqlDbType.SmallInt, 1).Value = Prj_Active;
            cmd.Parameters.Add("@Prj_Del", SqlDbType.SmallInt, 1).Value = Prj_Del;

            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet BindDropdowns(string Load)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Master_DropDowns";
            cmd.Parameters.Add("@Load", SqlDbType.NVarChar, 15).Value = Load;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}