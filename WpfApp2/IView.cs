using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    interface IView
    {

        event EventHandler<EventArgs> PressDigit;
        event EventHandler<EventArgs> PressOK;
        event EventHandler<EventArgs> PressClean;
        string EnteredData { get; set; }
    }
}
