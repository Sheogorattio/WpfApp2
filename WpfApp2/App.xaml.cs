using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        static public void Main()
        {
            App app = new App();
            MainWindow mainWindow = new MainWindow();
            Model model = new Model();
            //app.Run(mainWindow);
        }

    }
}
