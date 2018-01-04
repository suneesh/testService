using System.ServiceProcess;

namespace TestService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1(),
                new Service2()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
