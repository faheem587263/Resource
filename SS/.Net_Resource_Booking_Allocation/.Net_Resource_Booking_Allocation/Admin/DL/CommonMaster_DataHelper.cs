using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Net_Resource_Booking_Allocation.Admin.DL
{
    public class CommonMaster_DataHelper
    {
        String strConnString = ConfigurationManager.ConnectionStrings["ResourceAllocationConnectionString1"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();

        internal DataSet GetDropdowns(string Load)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Load", SqlDbType.NVarChar, 15).Value = Load;
            cmd.CommandText = "ProjectMaster_DropDowns";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        internal void AddCommon(string Flag, string Com_Name, string Com_Description, int Com_Insert_Usr_Id, int Com_Update_Usr_Id, int Com_Yr_Id, int Com_Active, int Com_Del)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "UpdateProject_Orders";
            //cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 6).Value = Flag;
            //cmd.Parameters.Add("@Prj_Client_Nam", SqlDbType.NVarChar, 200).Value = Prj_Client_Nam;
            //cmd.Parameters.Add("@Prj_Name", SqlDbType.NVarChar, 100).Value = Prj_Name;
            //cmd.Parameters.Add("@Prj_Details", SqlDbType.NVarChar, 1000).Value = Prj_Details;
            //cmd.Parameters.Add("@Prj_OnShore_EM_SDM", SqlDbType.NVarChar, 100).Value = Prj_OnShore_EM_SDM;
            //cmd.Parameters.Add("@Prj_OffShore_EM_SDM", SqlDbType.NVarChar, 200).Value = Prj_OffShore_EM_SDM;
            //cmd.Parameters.Add("@Prj_Exp_StartDate ", SqlDbType.DateTime, 10).Value = Prj_Exp_StartDate;
            //cmd.Parameters.Add("@Prj_Exp_EndDate", SqlDbType.DateTime, 10).Value = Prj_Exp_EndDate;
            //cmd.Parameters.Add("@Prj_Effort", SqlDbType.NVarChar, 300).Value = Prj_Effort;
            //cmd.Parameters.Add("@Prj_Revenue", SqlDbType.Int, 4).Value = Prj_Revenue;
            //cmd.Parameters.Add("@Prj_Contribution_Margin", SqlDbType.Decimal, 9).Value = Prj_Contribution_Margin;
            //cmd.Parameters.Add("@Prj_Expected_Rightshore_penetration", SqlDbType.Decimal, 9).Value = Prj_Expected_Rightshore_penetration;
            //cmd.Parameters.Add("@Prj_Comments", SqlDbType.NVarChar, 4000).Value = Prj_Comments;

            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}