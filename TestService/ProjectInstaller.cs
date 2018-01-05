using NLog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace cyberdome.parentalcontrol
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public ProjectInstaller()
        {
            logger.Debug("Service installer init");
            InitializeComponent();
        }

        private void serviceInstaller1_AfterInstall(object sender, InstallEventArgs e)
        {
            logger.Debug("Service installed");
        }
    }
}
