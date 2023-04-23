using diagram_8_lab.Models.Grids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagram_8_lab.Models.Serializers
{
    public class SerializebleGrid : SerializebleElement
    {
        public string StartPoint 
        { 
            get; 
            set; 
        }

        public string TypeGrid 
        { 
            get; 
            set; 
        }

        public double Width 
        { 
            get; 
            set;
        }
        public GridStrings GridText 
        { 
            get; 
            set; 
        }
        public double Height 
        { 
            get; 
            set; 
        }
        
    }
}
