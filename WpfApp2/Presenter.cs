using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    class Presenter
    {
        IModel _model;
        IView _view;

        public Presenter (IModel model, IView view)
        {
            _model = model;
            _view = view;
        }

        public void OnDigitPress(object sender, EventArgs e)
        {
            if (_model.IsPasswordTrue(_view.EnteredData)) MessageBox.Show("Correct password");
            else MessageBox.Show("Wrong password!");
        }

    }
}
