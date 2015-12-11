using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.Script.Services;
using System.Data;
using Net_Resource_Booking_Allocation.Admin.DL;
using System.Text;

namespace Net_Resource_Booking_Allocation.Admin
{
    public partial class ResourceAllocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["prjId"].ToString() != null)
                {
                    bind();
                    string value = Session["prjId"].ToString();
                    //drpprojectiD.SelectedItem.Value = value;
                    drpprojectiD.SelectedItem.Text = drpprojectiD.Items.FindByValue(value).Text;
                }
                else
                {
                    bind();
                }
               
            } 
        }

        [WebMethod(), ScriptMethod(UseHttpGet = true)]
        public static bool insertresourcedata(IEnumerable<dynamic> a, int projectId, int startweek, int endweek)
        {
            DataHelpers obj = new DataHelpers(); // obj for datahelperclass dblayer

            DataTable dt = new DataTable();
            dt.Columns.Add("resources");
            dt.Columns.Add("project");
            //dt.Columns.Add("skill");
            //dt.Columns.Add("glbgrd");
            //dt.Columns.Add("indgrd");
            //dt.Columns.Add("fte");
            //dt.Columns.Add("maxWeekHours");
            //dt.Columns.Add("durationHours");
            //dt.Columns.Add("fteHours");
            //dt.Columns.Add("totalHours");

            dt.Columns.Add("bookedHrs");
            dt.Columns.Add("startWeek");
            dt.Columns.Add("endWeek");
            dt.Columns.Add("rtcomment");
            dt.Columns.Add("rtInsertDate");
            dt.Columns.Add("rtUpdateDate");
            dt.Columns.Add("rtInsertUserId");
            dt.Columns.Add("rtUpdateUserId");
            dt.Columns.Add("rtYrId");

            foreach (var Item in a)
            {
                var dictionary = (Dictionary<string, object>)Item;
                for (int c = startweek; c <= endweek; c++)
                {
                    DataRow row = dt.NewRow();
                    row["resources"] = Convert.ToInt32(dictionary["resource"]);
                    row["project"] = 1;
                    //row["skill"] = dictionary["skill"];
                    //row["glbgrd"] = dictionary["glbgrd"];
                    //row["indgrd"] = dictionary["indgrd"];
                    //row["fte"] = dictionary["fte"];
                    //row["maxWeekHours"] = dictionary["maxWeekHours"];
                    //row["durationHours"] = dictionary["durationHours"];
                    //row["fteHours"] = dictionary["fteHours"];
                    //row["totalHours"] = dictionary["totalHours"];
                    row["bookedHrs"] = Convert.ToInt32(dictionary["" + c + ""]);
                    row["startWeek"] = c;
                    row["endWeek"] = c;
                    row["rtcomment"] = "AP";
                    row["rtInsertDate"] = DateTime.Now;
                    row["rtUpdateDate"] = DateTime.Now;
                    row["rtInsertUserId"] = 1;
                    row["rtUpdateUserId"] = 1;
                    row["rtYrId"] = 1;

                    dt.Rows.Add(row);
                }

            }
            obj.AddProjectTrans(dt);

            return true;
        }


        [WebMethod(), ScriptMethod(UseHttpGet = true)]
        //public static string getresourcedata(int fromweek, int toweek,int skillVal,string indgrdVal = null, string? fteFieldVal=null,int? glbgrdVal=null)
        public static string getresourcedata(int Prj_ID,int fromweek, int toweek, int skillVal, int? glbgrdVal, string indgrdVal = null, string fteFieldVal = null)
        {
            DataHelpers obj = new DataHelpers();
            DataTable dt = obj.Get_Resource_Data(Prj_ID,fromweek, toweek, skillVal, indgrdVal, fteFieldVal, glbgrdVal);
            return DataTableToJsonWithStringBuilder(dt);
        }


        public static string DataTableToJsonWithStringBuilder(DataTable table)
        {
            var jsonString = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                jsonString.Append("[");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    jsonString.Append("{");
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            jsonString.Append("\"" + table.Columns[j].ColumnName.ToString()
                                              + "\":" + "\""
                                              + table.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            jsonString.Append("\"" + table.Columns[j].ColumnName.ToString()
                                              + "\":" + "\""
                                              + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        jsonString.Append("}");
                    }
                    else
                    {
                        jsonString.Append("},");
                    }
                }
                jsonString.Append("]");
            }
            return jsonString.ToString();
        }


        public void bind()
        {
            ResourceMaster_DataHelper x = new ResourceMaster_DataHelper();
            drpprojectiD.DataSource = x.binddrop();
            drpprojectiD.DataValueField = "Prj_Id";
            drpprojectiD.DataTextField = "Prj_Name";
            
            drpprojectiD.DataBind();
        }

        protected void drpprojectiD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string projectID = drpprojectiD.SelectedItem.Value;
            DataHelpers obj = new DataHelpers();
            DataTable dt = obj.Get_Resource_Data(projectID);
            string source= DataTableToJsonWithStringBuilder(dt);
             getresourcedatareturn(source);
          
        }

        public string getresourcedatareturn(string data)
        {
            string jsondata = data;
            return jsondata;

        }

    }
}