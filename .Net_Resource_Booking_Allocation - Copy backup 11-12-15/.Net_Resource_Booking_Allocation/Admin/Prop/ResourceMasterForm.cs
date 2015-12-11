using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Net_Resource_Booking_Allocation.Admin.Prop
{
    public class ResourceMasterForm
    {
        public string Res_Name { get; set; }
        public int Res_Glb_Com_Id { get; set; }
        public int Res_Ind_Com_Id { get; set; }
        public int Res_Con_Id { get; set; }
        public int Res_Skl_Id { get; set; }
        public int Res_Hrs_Per_Week { get; set; }
        public string Res_Comments { get; set; }
        public string Res_Profile_Link { get; set; }
        public string Res_Role { get; set; }
        public UInt16 Res_Active { get; set; }
        public UInt16 Res_Del { get; set; }
        public DateTime Res_InsertDate { get; set; }
        public DateTime Res_UpdateDate { get; set; }
    }
}