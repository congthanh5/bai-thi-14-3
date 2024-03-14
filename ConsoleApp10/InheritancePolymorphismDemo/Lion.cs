using System;

namespace InheritancePolymorphismDemo
{
    
    class Lion : Animal
    {
        public Lion(double weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Animal Type: Lion");
            base.Show();
        }
    }
}
