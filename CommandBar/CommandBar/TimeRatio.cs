using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CommandBar
{
    public class TimeRatio: INotifyPropertyChanged
    {
        private int _timeRatio;
        
        public int TimeRatios
        {
            get { return _timeRatio; }
            set
            {
                _timeRatio = value;
                OnPropertyChanged("TimeRatios");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;

            // With C# 6 this can be replaced with
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
