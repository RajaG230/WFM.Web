using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WFM.Web.Models
{
    public class softlock
    {
        public int employee_id { get; set; }
        public string manager { get; set; }
        public DateTime reqdate { get; set; }
        public string status { get; set; }
        public DateTime lastupdated { get; set; }
        public int lockid { get; set; }
        public string requestmessage { get; set; }
        public string wfmremark { get; set; }
        public string managerstatus { get; set; }
        public string mgrstatuscomment { get; set; }
        public DateTime mgrlastupdate { get; set; }

    }
}
