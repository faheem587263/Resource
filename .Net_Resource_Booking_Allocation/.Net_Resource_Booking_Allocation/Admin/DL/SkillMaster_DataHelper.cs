using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Net_Resource_Booking_Allocation.Admin.DL
{
    public class SkillMaster_DataHelper
    {
        String strConnString = ConfigurationManager.ConnectionStrings["ResourceAllocationConnectionString1"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();

        internal System.Data.DataSet GetDropdowns(string Load)
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

        internal void AddSkill(string Flag, string Skl_Name, int Skl_Insert_Usr_Id,int Skl_Update_Usr_Id, int Skl_Yr_Id, int Skl_Active, int Skl_Del)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_SkillMaster";
            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 15).Value = Flag;
            cmd.Parameters.Add("@Skl_Name", SqlDbType.NVarChar, 200).Value = Skl_Name;
            cmd.Parameters.Add("@Skl_Yr_Id", SqlDbType.Int, 4).Value = Skl_Yr_Id;
            cmd.Parameters.Add("@Skl_Insert_Usr_Id", SqlDbType.Int, 4).Value = Skl_Insert_Usr_Id;
            cmd.Parameters.Add("@Skl_Update_Usr_Id", SqlDbType.Int, 4).Value = Skl_Update_Usr_Id;
            cmd.Parameters.Add("@Skl_Active ", SqlDbType.TinyInt, 1).Value = Skl_Active;
            cmd.Parameters.Add("@Skl_Del", SqlDbType.TinyInt, 1).Value = Skl_Del;

            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        internal void UpdateSkill(string Flag, int Skl_Id, string Skl_Name, int Skl_Update_Usr_Id, int Skl_Yr_Id, int Skl_Active, int Skl_Del)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_SkillMaster";
            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 15).Value = Flag;
            cmd.Parameters.Add("@Skl_Id", SqlDbType.Int, 4).Value = Skl_Id;
            cmd.Parameters.Add("@Skl_Name", SqlDbType.NVarChar, 200).Value = Skl_Name;
            cmd.Parameters.Add("@Skl_Yr_Id", SqlDbType.Int, 4).Value = Skl_Yr_Id;
            cmd.Parameters.Add("@Skl_Update_Usr_Id", SqlDbType.Int, 4).Value = Skl_Update_Usr_Id;
            cmd.Parameters.Add("@Skl_Active ", SqlDbType.TinyInt, 1).Value = Skl_Active;
            cmd.Parameters.Add("@Skl_Del", SqlDbType.TinyInt, 1).Value = Skl_Del;

            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        internal DataTable EditSkill(int Skl_Id, string Flag)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_SkillMaster";
            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 15).Value = Flag;
            cmd.Parameters.Add("@Skl_Id", SqlDbType.NVarChar, 15).Value = Skl_Id;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}