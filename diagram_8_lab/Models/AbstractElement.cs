using diagram_8_lab.Models.Grids;
using diagram_8_lab.Models.Lines;
using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace diagram_8_lab.Models
{
    public abstract class AbstractElement : AbstractNotifyPropertyChanged
    {
        protected uint id;
        private static uint id_generator = 0;
        
        public AbstractElement()
        {
            id = id_generator++;
        }

        public uint ID 
        { 
            get => id; 
            set => SetAndRaise(ref id, value); 
        }
    }
}
