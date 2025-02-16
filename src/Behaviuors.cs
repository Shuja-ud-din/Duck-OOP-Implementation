
public interface FlyBehavior
{
    public void Fly();
}
public class FlyNoWay : FlyBehavior
{
    public void Fly()
    {
        Console.WriteLine(" I'll never fly ");
    }
}
public class FlyWithWings : FlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with wings ");
    }
}


public interface QuackBehavior
{
    public void quack();
}
public class Quack : QuackBehavior
{
    public void quack()
    {
        Console.WriteLine("Quack Quack");
    }
}
public class Squeak : QuackBehavior
{
    public void quack()
    {
        Console.WriteLine("Squeak");
    }
}
public class MuteQuack : QuackBehavior
{
    public void quack()
    {
        Console.WriteLine("Silence");
    }
}