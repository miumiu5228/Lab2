using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box(); 
            Box Box2 = new Box();  
            Box Box3 = new Box(); 
            double volume = 0.0;  
            
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);
            Box1.setLength(6.0);
            
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);
            Box2.setLength(12.0);

            volume = Box1.getVolume();
            Console.WriteLine($"Volume of Box1 : {volume}");

            volume = Box2.getVolume();
            Console.WriteLine($"Volume of Box2 : {volume}");

            Box3 = Box1 + Box2;
            volume = Box3.getVolume();
            Console.WriteLine($"Volume of Box3 : {volume}");
        }
    }
}
