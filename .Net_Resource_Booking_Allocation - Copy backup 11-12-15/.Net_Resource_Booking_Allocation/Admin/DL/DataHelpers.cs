﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.Services;
using System.Web.Script.Services;


namespace Net_Resource_Booking_Allocation.Admin.DL
{
    public class DataHelpers
    {
        String strConnString = ConfigurationManager.ConnectionStrings["ResourceAllocationConnectionString1"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();

        public void UpdateRes(int Res_Id, string Res_Name, string Res_Hrs_Per_Week, string Res_Comments, string Res_Profile_Link, string Res_Role, int Res_Active, int Res_Del, string Res_Glb_Com_Id, string Res_Ind_Com_Id, string Res_Con_Id, string Res_Skl_Id, string Res_Insert_Usr_Id, string Res_Update_Usr_Id, string Res_Yr_Id, string Flag)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateResources";

            cmd.Parameters.Add("@Res_Id", SqlDbType.Int, 4).Value = Res_Id;
            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 6).Value = Flag;
            cmd.Parameters.Add("@Res_Name", SqlDbType.NVarChar, 1000).Value = Res_Name;
            cmd.Parameters.Add("@Res_Glb_Com_Id", SqlDbType.Int, 4).Value = Res_Glb_Com_Id == "" ? null : Res_Glb_Com_Id;
            cmd.Parameters.Add("@Res_Ind_Com_Id", SqlDbType.Int, 4).Value = Res_Ind_Com_Id == "" ? null : Res_Ind_Com_Id;
            cmd.Parameters.Add("@Res_Con_Id", SqlDbType.Int, 4).Value = Res_Con_Id == "" ? null : Res_Con_Id;
            cmd.Parameters.Add("@Res_Skl_Id ", SqlDbType.NVarChar, 600).Value = Res_Skl_Id == "" ? null : Res_Skl_Id;
            cmd.Parameters.Add("@Res_Hrs_Per_Week", SqlDbType.Int, 4).Value = Res_Hrs_Per_Week == "" ? null : Res_Hrs_Per_Week;
            cmd.Parameters.Add("@Res_Comments", SqlDbType.NVarChar, 4000).Value = Res_Comments;
            cmd.Parameters.Add("@Res_Profile_Link", SqlDbType.NVarChar, 2000).Value = Res_Comments;
            cmd.Parameters.Add("@Res_Role", SqlDbType.NVarChar, 400).Value = Res_Role;
            cmd.Parameters.Add("@Res_Active", SqlDbType.TinyInt, 1).Value = Res_Active;
            cmd.Parameters.Add("@Res_Del", SqlDbType.TinyInt, 1).Value = Res_Del;
            cmd.Parameters.Add("@Res_Insert_Usr_Id", SqlDbType.Int, 4).Value = Res_Insert_Usr_Id == "" ? null : Res_Insert_Usr_Id;
            cmd.Parameters.Add("@Res_Update_Usr_Id", SqlDbType.Int, 4).Value = Res_Update_Usr_Id == "" ? null : Res_Update_Usr_Id;
            cmd.Parameters.Add("@Res_Yr_Id", SqlDbType.Int, 4).Value = Res_Yr_Id == "" ? null : Res_Yr_Id;


            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable EditRes(int Res_Id, string Flag)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateResources";
            cmd.Parameters.Add("@Res_Id", SqlDbType.Int, 4).Value = Res_Id;
            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 6).Value = Flag;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void AddRes(string Res_Name, string Res_Hrs_Per_Week, string Res_Comments, string Res_Profile_Link, string Res_Role, int Res_Active, int Res_Del, string Res_Glb_Com_Id, string Res_Ind_Com_Id, string Res_Con_Id, string Res_Skl_Id, string Res_Insert_Usr_Id, string Res_Update_Usr_Id, string Res_Yr_Id, string Flag)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateResources";

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
        public void UpdateProject(string Flag, int Prj_Id, string Prj_Client_Nam, string Prj_Name, string Prj_Details, string Prj_OnShore_EM_SDM, string Prj_OffShore_EM_SDM, DateTime Prj_Exp_StartDate, DateTime Prj_Exp_EndDate, string Prj_Effort, string Prj_FTE, int Prj_Revenue, decimal Prj_Contribution_Margin, decimal Prj_Expected_Rightshore_penetration, string Prj_Comments)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateProject_Orders";

            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 6).Value = Flag;
            cmd.Parameters.Add("@Prj_Id", SqlDbType.Int, 4).Value = Prj_Id;
            cmd.Parameters.Add("@Prj_Client_Nam", SqlDbType.NVarChar, 200).Value = Prj_Client_Nam;
            cmd.Parameters.Add("@Prj_Name", SqlDbType.NVarChar, 100).Value = Prj_Name;
            cmd.Parameters.Add("@Prj_Details", SqlDbType.NVarChar, 1000).Value = Prj_Details;
            cmd.Parameters.Add("@Prj_OnShore_EM_SDM", SqlDbType.NVarChar, 100).Value = Prj_OnShore_EM_SDM;
            cmd.Parameters.Add("@Prj_OffShore_EM_SDM", SqlDbType.NVarChar, 200).Value = Prj_OffShore_EM_SDM;
            cmd.Parameters.Add("@Prj_Exp_StartDate ", SqlDbType.DateTime, 10).Value = Prj_Exp_StartDate;
            cmd.Parameters.Add("@Prj_Exp_EndDate", SqlDbType.DateTime, 10).Value = Prj_Exp_EndDate;
            cmd.Parameters.Add("@Prj_Effort", SqlDbType.NVarChar, 300).Value = Prj_Effort;
            cmd.Parameters.Add("@Prj_FTE", SqlDbType.NVarChar, 100).Value = Prj_FTE;
            //Res_Glb_Com_Id == "" ? null : Res_Glb_Com_Id;
            cmd.Parameters.Add("@Prj_Revenue", SqlDbType.Int, 4).Value = Prj_Revenue;
            cmd.Parameters.Add("@Prj_Contribution_Margin", SqlDbType.Decimal, 9).Value = Prj_Contribution_Margin;
            cmd.Parameters.Add("@Prj_Expected_Rightshore_penetration", SqlDbType.Decimal, 9).Value = Prj_Expected_Rightshore_penetration;
            cmd.Parameters.Add("@Prj_Comments", SqlDbType.NVarChar, 4000).Value = Prj_Comments;

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
            cmd.CommandText = "UpdateProject_Orders";
            cmd.Parameters.Add("@Prj_Id", SqlDbType.Int, 4).Value = Prj_Id;
            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 6).Value = Flag;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void AddProject(string Flag, string Prj_Client_Nam, string Prj_Name, string Prj_Details, string Prj_OnShore_EM_SDM, string Prj_OffShore_EM_SDM, DateTime Prj_Exp_StartDate, DateTime Prj_Exp_EndDate, string Prj_Effort, string Prj_FTE, int Prj_Revenue, decimal Prj_Contribution_Margin, decimal Prj_Expected_Rightshore_penetration, string Prj_Comments)
        {
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateProject_Orders";
            cmd.Parameters.Add("@Flag", SqlDbType.NVarChar, 6).Value = Flag;
            cmd.Parameters.Add("@Prj_Client_Nam", SqlDbType.NVarChar, 200).Value = Prj_Client_Nam;
            cmd.Parameters.Add("@Prj_Name", SqlDbType.NVarChar, 100).Value = Prj_Name;
            cmd.Parameters.Add("@Prj_Details", SqlDbType.NVarChar, 1000).Value = Prj_Details;
            cmd.Parameters.Add("@Prj_OnShore_EM_SDM", SqlDbType.NVarChar, 100).Value = Prj_OnShore_EM_SDM;
            cmd.Parameters.Add("@Prj_OffShore_EM_SDM", SqlDbType.NVarChar, 200).Value = Prj_OffShore_EM_SDM;
            cmd.Parameters.Add("@Prj_Exp_StartDate ", SqlDbType.DateTime, 10).Value = Prj_Exp_StartDate;
            cmd.Parameters.Add("@Prj_Exp_EndDate", SqlDbType.DateTime, 10).Value = Prj_Exp_EndDate;
            cmd.Parameters.Add("@Prj_Effort", SqlDbType.NVarChar, 300).Value = Prj_Effort;
            cmd.Parameters.Add("@Prj_FTE", SqlDbType.NVarChar, 100).Value = Prj_FTE;
            cmd.Parameters.Add("@Prj_Revenue", SqlDbType.Int, 4).Value = Prj_Revenue;
            cmd.Parameters.Add("@Prj_Contribution_Margin", SqlDbType.Decimal, 9).Value = Prj_Contribution_Margin;
            cmd.Parameters.Add("@Prj_Expected_Rightshore_penetration", SqlDbType.Decimal, 9).Value = Prj_Expected_Rightshore_penetration;
            cmd.Parameters.Add("@Prj_Comments", SqlDbType.NVarChar, 4000).Value = Prj_Comments;

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
            cmd.CommandText = "ProjectMaster_DropDowns";
            cmd.Parameters.Add("@Load", SqlDbType.NVarChar, 15).Value = Load;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        #region AP

        //To Insert Into Table tblResource_Trans
        public void AddProjectTrans(DataTable dt)
        {
            using (SqlConnection cn = new SqlConnection(strConnString))
            {
                cn.Open();
                using (SqlBulkCopy copy = new SqlBulkCopy(cn))
                {
                    //copy.ColumnMappings.Add(1, 0);
                    copy.ColumnMappings.Add(0, 1);
                    copy.ColumnMappings.Add(1, 2);
                    copy.ColumnMappings.Add(2, 3);
                    copy.ColumnMappings.Add(3, 4);
                    copy.ColumnMappings.Add(4, 5);
                    copy.ColumnMappings.Add(5, 6);
                    copy.ColumnMappings.Add(6, 7);
                    copy.ColumnMappings.Add(7, 8);
                    copy.ColumnMappings.Add(8, 9);
                    copy.ColumnMappings.Add(9, 10);
                    copy.ColumnMappings.Add(10, 11);
                    copy.DestinationTableName = "tblResource_Trans";
                    copy.WriteToServer(dt);
                }
            }
        }

        public DataTable Get_Resource_Data(int Prj_Id,int fromweek, int toweek, int skillVal, string indgrdVal = null, string fteFieldVal = null, int? glbgrdVal = null)
        //public DataTable Get_Resource_Data(int fromweek, int toweek, int skillVal)
        {
            //con = new SqlConnection(strConnString);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "SP_Get_ResourcesWeeklyWorkAllocation";
            ////cmd.Parameters.Add("@ResID", DBNull.Value);
            //cmd.Parameters.Add("@SkillID", SqlDbType.Int, 5).Value = skillVal;
            ////cmd.Parameters.Add("@Hours", DBNull.Value);
            //cmd.Parameters.Add("@GlbGrade", SqlDbType.Int, 5).Value = glbgrdVal;
            //cmd.Parameters.Add("@IndiaGrade", SqlDbType.VarChar, 50).Value = indgrdVal;
            //cmd.Parameters.Add("@FTE", SqlDbType.VarChar, 50).Value = fteFieldVal;
            ////cmd.Parameters.Add("@StartDate", DBNull.Value);
            ////cmd.Parameters.Add("@EndDate", DBNull.Value);
            ////cmd.Parameters.Add("@ReportPeriodType", DBNull.Value);
            //cmd.Parameters.Add("@StartWeek", SqlDbType.Int,5).Value=fromweek;
            //cmd.Parameters.Add("@EndWeek", SqlDbType.Int, 5).Value = toweek;
            //cmd.Connection = con;
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //return dt;

            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Get_ResourcesWeeklyWorkAllocation";
            cmd.Parameters.Add("@Proj_Id", SqlDbType.Int, 5).Value = Prj_Id;
            //cmd.Parameters.Add("@ResID", DBNull.Value);
            cmd.Parameters.Add("@SkillID", SqlDbType.Int, 5).Value = skillVal;
            //cmd.Parameters.Add("@Hours", DBNull.Value);
            //cmd.Parameters.Add("@GlbGrade", SqlDbType.Int, 5).Value = glbgrdVal;
            //cmd.Parameters.Add("@IndiaGrade", SqlDbType.VarChar, 50).Value = indgrdVal;
            //cmd.Parameters.Add("@FTE", SqlDbType.VarChar, 50).Value = fteFieldVal;
            //cmd.Parameters.Add("@StartDate", DBNull.Value);
            //cmd.Parameters.Add("@EndDate", DBNull.Value);
            //cmd.Parameters.Add("@ReportPeriodType", DBNull.Value);
            cmd.Parameters.Add("@StartWeek", SqlDbType.Int, 5).Value = fromweek;
            cmd.Parameters.Add("@EndWeek", SqlDbType.Int, 5).Value = toweek;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }





        public DataTable Get_Resource_Data(string Prj_Id)
      
        {
           
            con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetResourceAllocationByProjId";
            cmd.Parameters.Add("@proj_Id", SqlDbType.Int, 5).Value = "1";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

    }
}