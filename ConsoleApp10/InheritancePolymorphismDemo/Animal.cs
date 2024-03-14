using System;

namespace InheritancePolymorphismDemo
{

    class Animal
    {
        protected double weight;
        protected string name;

        public Animal(double weight, string name)
        {
            SetMe(weight, name);
        }

        public void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Weight: " + weight + " kg");
        }
    }
}
