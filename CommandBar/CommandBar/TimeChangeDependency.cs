using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPropertyChanged_PerfTest
{
    public interface IHaveAProperty
    {
        int TimeChange { get; set; }
    }
}
