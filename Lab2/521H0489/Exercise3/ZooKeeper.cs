using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class ZooKeeper
    {
        public List<Animal> animals;

        public ZooKeeper()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void RemoveAnimal(string animalName)
        {
            Animal? animal = FindAnimal(animalName);
            if (animal != null)
            {
                animals.Remove(animal);
            }
        }

        public Animal? FindAnimal(string animalName)
        {
            Animal? animal = animals.Find(a => a.Name == animalName);
            return animal;
        }

        public List<Animal> FilterAnimals(Func<Animal, bool> criteria)
        {
            return animals.Where(criteria).ToList();
        }

    }
}
