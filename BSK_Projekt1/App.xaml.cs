using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BSK_Projekt1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            string json = JsonConvert.SerializeObject(UsersSingleton.Instance.Users, Formatting.Indented);
            File.WriteAllText(Path.Combine(@"..\..\", "users.xml"), json);
        }
    }
}
