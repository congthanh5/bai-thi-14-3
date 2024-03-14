using System;

namespace InheritancePolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion(100, "tiger");
            Tiger tiger = new Tiger(200, "lion");

            lion.Show();
            Console.WriteLine();
            tiger.Show();
        }
    }
}
