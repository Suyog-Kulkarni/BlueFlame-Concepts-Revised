/*
public abstract class A
{
    public abstract string Name { get; set; }
    public abstract void Start();

    public virtual void Run()
    {
        Console.WriteLine("A::Run");
    }

}
class B : A
{
    public override string Name { get; set; } = String.Empty;// can also create abstract properties
    public override void Start()
    {
        Console.WriteLine("B::Start");
    }

    public override void Run()
    {
        Console.WriteLine("A::Run");
    }
    // the difference between virtual and astract is that virtual has a body and abstract does not have a body 
    // abstract is used when you want to force the child class to implement the method 
   
}
//var a = new A(); // cannot create an instance of an abstract class

// one class and one interface

public interface I
{
    void IStart();
}
public interface I2
{
    void IRun();
}

class C : I, I2
{
  
    public void IStart()
    {
        Console.WriteLine("I::Start");
    }

    public void IRun()
    {
        Console.WriteLine("I2::Run");
    }
    // a class can inherit from one class and one interface
    // 

     
}*/
public class MyClass
{
    private int value;

    public MyClass() : this(0) { /* Constructor chaining */ }

    public MyClass(int value)
    {
        this.value = value;
    }

    public void display()
    {
        Console.WriteLine("The value is: " + value);
        int a = 5;
        int b = 3;

        a = a^b;
        b = a^b;
        a = a^b;

        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);
    }

    public static void Main()
    {
        var obj = new MyClass();
        obj.display();
    }
}