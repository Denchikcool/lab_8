using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagram_8_lab.Models.Serializers
{
    public class JSONSaverLoaderFactory : ISaverLoaderFactory
    {
        public IShapeSaver CreateSaver(){
            return new JSONSaver();
        }

        public IShapeLoader CreateLoader()
        {
            return new JSONLoader();
        }

        public bool IsMatch(string path){
            return ".json".Equals(Path.GetExtension(path));
        }
    }
}
