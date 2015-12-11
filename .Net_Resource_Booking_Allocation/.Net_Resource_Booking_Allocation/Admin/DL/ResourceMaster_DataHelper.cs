using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Net_Resource_Booking_Allocation.Admin.DL
{
    public class ResourceMaster_DataHelper
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

        internal void UpdateRes(int Res_Id, string Res_Name, string Res_Hrs_Per_Week, string Res_Comments, string Res_Profile_Link, string Res_Role, int Res_Active, int Res_Del, int Res_Glb_Com_Id, int Res_Ind_Com_Id, int Res_Con_Id, int Res_Skl_Id, int Res_Insert_Usr_Id, int Res_Update_Usr_Id, int Res_Yr_Id, string Flag)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ResourceMaster";

            cmd.Parameters.Add("@Res_Id", SqlDbType.Int, 4).Value = Res_Id;
            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 6).Value = Flag;
            cmd.Parameters.Add("@Res_Name", SqlDbType.NVarChar, 1000).Value = Res_Name;
            cmd.Parameters.Add("@Res_Glb_Com_Id", SqlDbType.Int, 4).Value = Res_Glb_Com_Id;
            cmd.Parameters.Add("@Res_Ind_Com_Id", SqlDbType.Int, 4).Value = Res_Ind_Com_Id ;
            cmd.Parameters.Add("@Res_Con_Id", SqlDbType.Int, 4).Value = Res_Con_Id ;
            cmd.Parameters.Add("@Res_Skl_Id ", SqlDbType.NVarChar, 600).Value = Res_Skl_Id ;
            cmd.Parameters.Add("@Res_Hrs_Per_Week", SqlDbType.Int, 4).Value = Res_Hrs_Per_Week;
            cmd.Parameters.Add("@Res_Comments", SqlDbType.NVarChar, 4000).Value = Res_Comments;
            cmd.Parameters.Add("@Res_Profile_Link", SqlDbType.NVarChar, 2000).Value = Res_Profile_Link;
            cmd.Parameters.Add("@Res_Role", SqlDbType.NVarChar, 400).Value = Res_Role;
            cmd.Parameters.Add("@Res_Active", SqlDbType.TinyInt, 1).Value = Res_Active;
            cmd.Parameters.Add("@Res_Del", SqlDbType.TinyInt, 1).Value = Res_Del;
            cmd.Parameters.Add("@Res_Insert_Usr_Id", SqlDbType.Int, 4).Value = Res_Insert_Usr_Id ;
            cmd.Parameters.Add("@Res_Update_Usr_Id", SqlDbType.Int, 4).Value = Res_Update_Usr_Id ;
            cmd.Parameters.Add("@Res_Yr_Id", SqlDbType.Int, 4).Value = Res_Yr_Id ;


            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        internal void AddRes(string Res_Name, string Res_Hrs_Per_Week, string Res_Comments, string Res_Profile_Link, string Res_Role, int Res_Active, int Res_Del, int Res_Glb_Com_Id, int Res_Ind_Com_Id, int Res_Con_Id, int Res_Skl_Id, int Res_Insert_Usr_Id, int Res_Update_Usr_Id, int Res_Yr_Id, string Flag)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ResourceMaster";

            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 6).Value = Flag;
            cmd.Parameters.Add("@Res_Name", SqlDbType.NVarChar, 1000).Value = Res_Name;
            cmd.Parameters.Add("@Res_Glb_Com_Id", SqlDbType.Int, 4).Value = Res_Glb_Com_Id;
            cmd.Parameters.Add("@Res_Ind_Com_Id", SqlDbType.Int, 4).Value = Res_Ind_Com_Id;
            cmd.Parameters.Add("@Res_Con_Id", SqlDbType.Int, 4).Value = Res_Con_Id;
            cmd.Parameters.Add("@Res_Skl_Id ", SqlDbType.NVarChar, 600).Value = Res_Skl_Id;
            cmd.Parameters.Add("@Res_Hrs_Per_Week", SqlDbType.Int, 4).Value = Res_Hrs_Per_Week;
            cmd.Parameters.Add("@Res_Comments", SqlDbType.NVarChar, 4000).Value = Res_Comments;
            cmd.Parameters.Add("@Res_Profile_Link", SqlDbType.NVarChar, 2000).Value = Res_Comments;
            cmd.Parameters.Add("@Res_Role", SqlDbType.NVarChar, 400).Value = Res_Role;
            cmd.Parameters.Add("@Res_Active", SqlDbType.TinyInt, 1).Value = Res_Active;
            cmd.Parameters.Add("@Res_Del", SqlDbType.TinyInt, 1).Value = Res_Del;
            cmd.Parameters.Add("@Res_Insert_Usr_Id", SqlDbType.Int, 4).Value = Res_Insert_Usr_Id;
            cmd.Parameters.Add("@Res_Update_Usr_Id", SqlDbType.Int, 4).Value = Res_Update_Usr_Id;
            cmd.Parameters.Add("@Res_Yr_Id", SqlDbType.Int, 4).Value = Res_Yr_Id;


            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        internal DataTable EditRes(int Res_Id, string Flag)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ResourceMaster";
            cmd.Parameters.Add("@Res_Id", SqlDbType.Int, 4).Value = Res_Id;
            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 6).Value = Flag;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataSet binddrop()
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ProjectMaster_DropDownsID";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
         
        }
    }
}