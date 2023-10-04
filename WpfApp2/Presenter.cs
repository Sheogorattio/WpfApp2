using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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
            _view.PressClean += new EventHandler<EventArgs>(OnCleanPress);
            _view.PressOK += new EventHandler<EventArgs>(OnAcceptPress);
            _view.PressDigit += new EventHandler<EventArgs>(OnDigitPress);
        }

        public void OnAcceptPress(object sender, EventArgs e)
        {
            if (_model.IsPasswordTrue())
            {
                _view.EnteredData = "Accepted";
            }
            else
            {
                _view.EnteredData = "Declined";
            }
            _model.CleanEnteredData();
            _model.RefreshPassword();
        }

        public void OnCleanPress(object sender, EventArgs e) 
        {
            _view.EnteredData = " ";
            _model.CleanEnteredData();
        }

        public void OnDigitPress(object sender, EventArgs e)
        {
            _view.EnteredData += ((Button)sender)?.Content.ToString();
            _model.EnteredData = ((Button)sender)?.Content.ToString();
        }
    }
}
