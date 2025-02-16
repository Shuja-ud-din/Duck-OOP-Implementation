using System;

namespace DuckProject
{
    public abstract class Duck
    {

        public FlyBehavior? flyBehavior;
        public QuackBehavior? quackBehavior;

        public void Quack()
        {
            quackBehavior?.quack();
        }

        public void Swim()
        {
            Console.WriteLine("I am swimming!");
        }

        public void Fly()
        {
            flyBehavior?.Fly();
        }

        public abstract void display();
    }



    public class Mallard : Duck
    {
        public Mallard()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("I am a Mallard");
        }
    }
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I am a Redhead Duck");
        }
    }
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }

        public override void display()
        {
            Console.WriteLine("I am a Rubber Duck");
        }
    }
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void display()
        {
            Console.WriteLine("I am a Decoy Duck");
        }
    }
}


