using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    class Model : IModel
    {
        string password;

        public Model()
        {
            password =  DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00");
            MessageBox.Show(password);
        }
        public bool IsPasswordTrue(string pswd)
        {
            return password == pswd;
        }
    }
}
