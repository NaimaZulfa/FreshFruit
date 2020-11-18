using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreshFruit.Model
{
    class Bucket
    {
        private int capasity;
        private List<Fruit> fruits;

        public Bucket(int capasity)
        {
            this.capasity = capasity;
            this.fruits = new List<Fruit>();
        }
        public void insert(Fruit fruit)
        {
            this.fruits.Add(fruit);
        }
        public void remove(int position)
        {
            this.fruits.RemoveAt(position);
        }
        public List<Fruit> findAll()
        {
            return this.fruits;
        }
        public int getCapacity()
        {
            return this.capasity;
        }
        public int countItems()
        {
            return this.fruits.Count();
        }
    }
}
