using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsShelter
{
    class Shelter : IEnumerable
    {
        public int MaxPlaces { get; set; }
        public int EmptyPlaces { get { return MaxPlaces - animals.Count; } }

        private List<Animal> animals = new List<Animal>();

        public Shelter() { }
        public Shelter(int maxPlaces)
        {
            MaxPlaces = maxPlaces;
        }

        public void AddAnimal(Animal a)
        {
            if (animals.Count < MaxPlaces)
                animals.Add(a);
        }

        public void RemoveAnimal(int place)
        {
            animals.RemoveAt(place);
        }

        public IEnumerator GetEnumerator()
        {
            return animals.GetEnumerator();
        }
    }
}
