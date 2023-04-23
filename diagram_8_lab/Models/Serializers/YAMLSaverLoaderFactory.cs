using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagram_8_lab.Models.Serializers
{
    public class YAMLSaverLoaderFactory : ISaverLoaderFactory
    {

        public IShapeSaver CreateSaver()
        {
            return new YAMLSaver();
        }
        public IShapeLoader CreateLoader()
        {
            return new YAMLLoader();
        }

        public bool IsMatch(string path)
        {
            return ".yaml".Equals(Path.GetExtension(path));
        }
    }
}
