using System.Collections.Generic;

namespace Want2Learn.ClassAndObjects
{
    public interface IAnimalService
    {
        void WriteInfo(Animal[] animals, string filePath);
        void WriteInfo(List<Animal> animals, string filePath);
    }
}