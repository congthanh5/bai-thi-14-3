using System;

namespace GeometryExample
{
    class Cylinder
    {
        // Properties
        public double Radius { get; set; }
        public double Height { get; set; }
        public double BaseArea { get; private set; }
        public double LateralArea { get; private set; }
        public double TotalArea { get; private set; }
        public double Volume { get; private set; }

        // Method to calculate
        public void Process()
        {
            Console.Write("Nhập bán kính của hình trụ: ");
            Radius = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều cao của hình trụ: ");
            Height = double.Parse(Console.ReadLine());

            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        // Method to display results
        public void Result()
        {
            Console.WriteLine("\nKết quả:");
            Console.WriteLine("Diện tích đáy: " + BaseArea);
            Console.WriteLine("Diện tích xung quanh: " + LateralArea);
            Console.WriteLine("Tổng diện tích: " + TotalArea);
            Console.WriteLine("Thể tích: " + Volume);
        }
    }
}
