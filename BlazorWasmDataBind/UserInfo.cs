using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmDataBind
{
    public class UserInfo: INotifyPropertyChanged
    {
        private string _userName;
        public string UserName {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UserName)));
            }
         }

        public string Sex { get; set; }

        public DateTime BrithDay { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
