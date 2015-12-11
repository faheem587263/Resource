using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Net_Resource_Booking_Allocation.Admin.DL
{
    public class CountryMaster_DataHelper 
    {
        String strConnString = ConfigurationManager.ConnectionStrings["ResourceAllocationConnectionString1"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();

        internal void AddCommon(string Flag, string Con_Name, string Com_Description, int Com_Grp_Id, int Com_Insert_Usr_Id, int Com_Yr_Id, int Com_Active, int Com_Del)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "SP_CommonMaster";
            //cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 15).Value = Flag;
            //cmd.Parameters.Add("@Com_Name", SqlDbType.NVarChar, 100).Value = Com_Name;
            //cmd.Parameters.Add("@Com_Description", SqlDbType.NVarChar, 1000).Value = Com_Description;
            //cmd.Parameters.Add("@Com_Grp_Id", SqlDbType.Int, 4).Value = Com_Grp_Id;
            //cmd.Parameters.Add("@Com_Insert_Usr_Id", SqlDbType.Int, 4).Value = Com_Insert_Usr_Id;
            //cmd.Parameters.Add("@Com_Yr_Id", SqlDbType.Int, 4).Value = Com_Yr_Id;
            //cmd.Parameters.Add("@Com_Active ", SqlDbType.TinyInt, 1).Value = Com_Active;
            //cmd.Parameters.Add("@Com_Del", SqlDbType.TinyInt, 1).Value = Com_Del;


            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}