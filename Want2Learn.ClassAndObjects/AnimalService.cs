using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.ClassAndObjects
{
    public class AnimalService
    {
        public void WriteInfo(List<Animal> animals, string filePath)
        {
            if ((animals == null) || (filePath == null))
            {
                return;
            }
            using (StreamWriter streamWriter = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine(JsonConvert.SerializeObject(animals, Formatting.Indented));
            }
        }

        public void WriteInfo(Animal[] animals, string filePath)
        {
            if ((animals == null) || (filePath == null))
            {
                return;
            }
            using (StreamWriter streamWriter = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine(JsonConvert.SerializeObject(animals, Formatting.Indented));
            }
        }
    }
}
