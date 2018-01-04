using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace TestService
{
    [RunInstaller(true)]
    public partial class TestServiceInstaller : Installer
    {
        public TestServiceInstaller()
        {
            
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);
        }

        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);
        }

        //void Commit(IDictionary savedState)
        //{
        //    base.Commit(savedState);
        //}

        //void Rollback(IDictionary savedState)
        //{

        //}

        //void OnAfterInstall(IDictionary savedState)
        //{

        //}
        //void OnAfterRollback(IDictionary savedState)
        //{

        //}
        //void OnAfterUninstall(IDictionary savedState)
        //{

        //}
        //void OnBeforeInstall(IDictionary savedState)
        //{

        //}
        //void OnBeforeRollback(IDictionary savedState)
        //{
        //}
        //void OnBeforeUninstall(IDictionary savedState)
        //{

        //}
        //void OnCommitted(IDictionary savedState)
        //{

        //}
        //void OnCommitting(IDictionary savedState)
        //{

        //}
    }
}
