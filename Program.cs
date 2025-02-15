using System;

namespace DuckProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck();
            duck.Quack();
            duck.Swim();
            duck.Display();
            duck.Fly();
        }
    }
}