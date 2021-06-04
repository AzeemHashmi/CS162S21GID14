using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS162S21GID14.Models
{
    public class AdminAccount : Account
    {
        private static AdminAccount instance = null;
        public List<Report> ReportList { get; set; }

        private AdminAccount()
        {
            ReportList = new List<Report>();
        }
        public static AdminAccount Instance {
            get
            {
                if(instance== null)
                {
                    instance = new AdminAccount();
                }
                return instance;
            }
        }

        public bool AddReport(Report rep)
        {
            bool flag = false;
            if (SearchReport(rep) != -1)
            {
                ReportList.Add(rep);
                flag = true;
            }
            return flag;
        }
        public bool DeleteReport(Report rep)
        {
            bool flag = true;
            ReportList.Remove(rep);
            return flag;
        }
        public int SearchReport(Report rep)
        {
            for (int i = 0; i < ReportList.Count; i++)
            {
                if (rep == ReportList[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}