using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp2
{
    class ListBox1ItemViewModel: INotifyPropertyChanged
    {
        public event ProgressChangedEventHandler PropertyChanged;
        private String _line1;
        public String LINE1
        {
            get
            {
                return _line1;
            }
            set
            {
                if (_line1 != value)
                    _line1 = value;
                //if (PropertyChanged != null)
                //    PropertyChanged(this,new PropertyChangedEventArgs("LINE1"));
            }
        }
    }
}
