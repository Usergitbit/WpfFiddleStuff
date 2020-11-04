using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFiddleStuff
{
    public class LodHeader
    {
        public string Info0 { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public ObservableCollection<Model> Models { get; set; } = new ObservableCollection<Model>();
    }
}
