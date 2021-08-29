using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Want2Learn.Interfaces;
using Want2Learn.Models.Animals;

namespace Want2Learn.Services
{
    public class AnimalService : IAnimalService
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
