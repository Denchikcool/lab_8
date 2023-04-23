using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace diagram_8_lab.Models.Serializers
{
    public class XMLSaverLoaderFactory : ISaverLoaderFactory
    {

        public IShapeSaver CreateSaver()
        {
            return new XMLSaver();
        }
        public IShapeLoader CreateLoader()
        {
            return new XMLLoader();
        }

        public bool IsMatch(string path)
        {
            return ".xml".Equals(Path.GetExtension(path));
        }
    }
}
