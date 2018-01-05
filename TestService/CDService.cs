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
using System.Threading;

namespace cyberdome.parentalcontrol
{
    public partial class CDService : ServiceBase
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public CDService()
        {
            InitializeComponent();
            this.ServiceName = Constants.MainServiceName;
        }

        public void DebugLaunch()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            logger.Debug("CDService start");
            Thread t = new Thread(MonitoringThread);
            t.Start();
        }

        protected override void OnStop()
        {
            logger.Debug("CDService stop");
        }

        private static void MonitoringThread()
        {
            while(true)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
