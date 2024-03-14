using System;

namespace InheritancePolymorphismDemo
{
    
    class Tiger : Animal
    {
        public Tiger(double weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Animal Type: Tiger");
            base.Show();
        }
    }
}
