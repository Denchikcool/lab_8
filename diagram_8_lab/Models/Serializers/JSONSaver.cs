using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagram_8_lab.Models.Serializers
{
    public class JSONSaver : IShapeSaver
    {
        public void Save(ObservableCollection<AbstractElement> figures, string path)
        {
            ObservableCollection<SerializebleElement> ser = ConvertElementToSerializeObject.ToSerializer(figures);
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            string output = string.Empty;
            output = JsonConvert.SerializeObject(ser.ToList(),
                new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    TypeNameHandling = TypeNameHandling.All
                });

            using (StreamWriter writer = new StreamWriter(path)){
                writer.WriteLine(output);
            }
        }
    }
}
