using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Net_Resource_Booking_Allocation.Admin.DL
{
    public class GroupMaster_DataHelper
    {

        String strConnString = ConfigurationManager.ConnectionStrings["ResourceAllocationConnectionString1"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();

        internal DataSet GetDropdowns(string Load)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Load", SqlDbType.NVarChar, 15).Value = Load;
            cmd.CommandText = "SP_Master_DropDowns";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        internal void AddGroup(string Flag, string Grp_Name, string Grp_Description, int Grp_Insert_Usr_Id, int Grp_Update_Usr_Id, int Grp_Yr_Id, int Grp_Active, int Grp_Del)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GroupMaster";
            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 15).Value = Flag;
            cmd.Parameters.Add("@Grp_Name", SqlDbType.NVarChar, 100).Value = Grp_Name;
            cmd.Parameters.Add("@Grp_Description", SqlDbType.NVarChar, 1000).Value = Grp_Description;
            cmd.Parameters.Add("@Grp_Yr_Id", SqlDbType.Int, 4).Value = Grp_Yr_Id;
            cmd.Parameters.Add("@Grp_Insert_Usr_Id", SqlDbType.Int, 4).Value = Grp_Insert_Usr_Id;
            cmd.Parameters.Add("@Grp_Update_Usr_Id", SqlDbType.Int, 4).Value = Grp_Update_Usr_Id;
            cmd.Parameters.Add("@Grp_Active ", SqlDbType.TinyInt, 1).Value = Grp_Active;
            cmd.Parameters.Add("@Grp_Del", SqlDbType.TinyInt, 1).Value = Grp_Del;


            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        internal void UpdateGroup(string Flag, int Grp_Id, string Grp_Name, string Grp_Description, int Grp_Update_Usr_Id, int Grp_Yr_Id, int Grp_Active, int Grp_Del)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GroupMaster";
            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 15).Value = Flag;
            cmd.Parameters.Add("@Grp_Id", SqlDbType.Int, 4).Value = Grp_Id;
            cmd.Parameters.Add("@Grp_Name", SqlDbType.NVarChar, 100).Value = Grp_Name;
            cmd.Parameters.Add("@Grp_Description", SqlDbType.NVarChar, 1000).Value = Grp_Description;
            cmd.Parameters.Add("@Grp_Yr_Id", SqlDbType.Int, 4).Value = Grp_Yr_Id;
            cmd.Parameters.Add("@Grp_Update_Usr_Id", SqlDbType.Int, 4).Value = Grp_Update_Usr_Id;
            cmd.Parameters.Add("@Grp_Active ", SqlDbType.TinyInt, 1).Value = Grp_Active;
            cmd.Parameters.Add("@Grp_Del", SqlDbType.TinyInt, 1).Value = Grp_Del;


            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        internal DataTable EditGroup(int Grp_Id, string Flag)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GroupMaster";
            cmd.Parameters.Add("@Grp_Id", SqlDbType.Int, 4).Value = Grp_Id;
            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 15).Value = Flag;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}