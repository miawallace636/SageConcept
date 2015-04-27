using SageConcept.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SageConcept
{
    public partial class App : Application
    {
        /// <summary>
        /// Interaction logic for App.xaml
        /// </summary>
        protected override void OnStartup(StartupEventArgs e)
        {
            //base.OnStartup(e);

            //// The boostrapper will create the Shell instance, so the App.xaml does not have a StartupUri.
            //Bootstrapper bootstrapper = new Bootstrapper();
            //bootstrapper.Run();
        }
    }
}
