using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    interface IModel
    {
        bool IsPasswordTrue();
        void RefreshPassword();

        string EnteredData { set; }
        void CleanEnteredData();
    }
}
