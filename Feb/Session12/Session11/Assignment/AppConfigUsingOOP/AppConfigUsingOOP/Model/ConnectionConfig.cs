using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigUsingOOP.Model
{
    internal class ConnectionConfig
    {
        public ConnectionConfig()
        {
            var appSettings = ConfigurationManager.AppSettings;
            Connection1 = appSettings["connection1"];
            Connection2 = appSettings["connection2"];
        }

        public string Connection1
        {
            get; set;
        }
        public string Connection2
        {
            get;set;
        }

    }
}
