using NLog;
using System.ServiceProcess;
using System.Threading;

namespace cyberdome.parentalcontrol
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Debug("Main");
            if (System.Environment.UserInteractive)
            {
                // Debug directly from Visual Studio

                //new CDService().DebugLaunch();
                new KeepAliveCD().DebugStart();
            }
            else
            {
                logger.Debug("Service startup");
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new CDService(),
                new KeepAliveCD()
                };
                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}
