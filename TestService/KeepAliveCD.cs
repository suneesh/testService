using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cyberdome.parentalcontrol
{
    partial class KeepAliveCD : ServiceBase
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private const string MainServiceName = "CDService";
        

        public KeepAliveCD()
        {
            InitializeComponent();
            this.ServiceName = Constants.KeepAliveServiceName;
        }

        public void DebugStart()
        {
            OnStart(null);
        }
        protected override void OnStart(string[] args)
        {
            logger.Debug("Keepalive servie start");
            Thread t = new Thread(CheckForMainService);
            t.Start();
        }

        protected override void OnStop()
        {
            logger.Debug("Keepalive servie stop");
        }

        private static void CheckForMainService()
        {
            logger.Debug("Keepalive thread start");
            ServiceController serviceController = new ServiceController("CoreMessaging"/*Constants.MainServiceName*/);
            while (true)
            {
                serviceController.Refresh();
                logger.Debug(serviceController.Status);

                switch (serviceController.Status)
                {
                    case ServiceControllerStatus.Running:
                        break;
                    case ServiceControllerStatus.Stopped:
                        break;
                    case ServiceControllerStatus.Paused:
                        break;
                    case ServiceControllerStatus.StopPending:
                        break;
                    case ServiceControllerStatus.StartPending:
                        break;
                    default:
                        break;
                }
                Thread.Sleep(10000);
            }
        }

    }
}
