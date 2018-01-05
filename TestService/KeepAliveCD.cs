using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    partial class KeepAliveCD : ServiceBase
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public KeepAliveCD()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            logger.Trace("Keepalive servie start");
        }

        protected override void OnStop()
        {
            logger.Trace("Keepalive servie stop");
        }


    }
}
