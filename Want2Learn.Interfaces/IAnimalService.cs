using System.Collections.Generic;
using Want2Learn.Models.Animals;

namespace Want2Learn.Interfaces
{
    public interface IAnimalService
    {
        void WriteInfo(Animal[] animals, string filePath);
        void WriteInfo(List<Animal> animals, string filePath);
    }
}