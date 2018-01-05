using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace TestService
{
    public partial class CDService : ServiceBase
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public CDService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            logger.Trace("CDService start");
        }

        protected override void OnStop()
        {
            logger.Trace("CDService stop");
        }
    }
}
