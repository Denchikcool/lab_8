using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagram_8_lab.Models.Serializers
{
    public interface ISaverLoaderFactory
    {
        bool IsMatch(string path);
        IShapeLoader CreateLoader();
        IShapeSaver CreateSaver();
    }
}
