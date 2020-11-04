using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFiddleStuff
{
    public class ModelFile
    {
        public string Property { get; set; } = "This a prop";
        public ObservableCollection<LodHeader> Lods { get; set; } = new ObservableCollection<LodHeader>();
    }
}
