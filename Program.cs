using System;

namespace DuckProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new Mallard();
            mallard.display();
            mallard.Fly();
            mallard.Quack();
            mallard.Swim();

            Duck redheadDuck = new RedheadDuck();
            redheadDuck.display();
            redheadDuck.Fly();
            redheadDuck.Quack();
            redheadDuck.Swim();

            Duck rubberDuck = new RubberDuck();
            rubberDuck.display();
            rubberDuck.Fly();
            rubberDuck.Quack();
            rubberDuck.Swim();



            Duck decoyDuck = new DecoyDuck();
            decoyDuck.display();
            decoyDuck.Fly();
            decoyDuck.Quack();
            decoyDuck.Swim();


        }
    }
}