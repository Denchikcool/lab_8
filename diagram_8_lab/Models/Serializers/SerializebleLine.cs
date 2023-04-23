using diagram_8_lab.Models.Grids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagram_8_lab.Models.Serializers
{
    public class SerializebleLine : SerializebleElement
    {
        public int ConnectionPointSecond { get; set; }
        public string EndPoint { get; set; }
        public string TypeLine { get; set; }
        public double Lenght { get; set; }
        public uint SecondGridID { get; set; }
        public double Angle { get; set; }
        public string StartPoint { get; set; }
        public double LineCenterX { get; set; }
        public uint FirstGridID { get; set; }
        public int ConnectionPointFirst { get; set; }
        
    }
}
