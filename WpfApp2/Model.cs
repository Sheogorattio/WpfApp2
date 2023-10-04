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
        string password = " ";
        private StringBuilder enteredData;

        public Model()
        {
           RefreshPassword();
            enteredData = new StringBuilder();
        }

        
        public string EnteredData { set { enteredData.Append(value.ToString()); } }

        public bool IsPasswordTrue()
        {
            return password == enteredData.ToString();
        }

        public void RefreshPassword()
        {
            password = DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00");
        }

        public void CleanEnteredData()
        {
         enteredData.Clear();
        }
    }
}
