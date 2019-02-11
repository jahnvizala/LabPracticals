using System;

 class Car
{
     protected string color;
     public Car(string color1)
     {
         color = color1;
     }
      protected int price;
    public virtual void Carmethod()
    {
        Console.WriteLine("this is the main class");
    }
}
 class Maruti : Car
{
     int speed;
     public override void Carmethod()
     {
         Console.WriteLine("this is the derived maruti class");
     }
     public Maruti(string color2,int price2,int speed2):base(color)
     {
         color = color2;
         price = price2;
         speed = speed2;
     }
     public void method1()
     {
         Console.WriteLine("color is:" + color);
         Console.WriteLine("price is:" + price);
         Console.WriteLine("speed is:" + speed);
     }
}
 class Mahindra : Car
{
     int id;
     public override void Carmethod()
     {
         Console.WriteLine("this is the derived mahindra class");
     }
     public Mahindra(string color1,int price1,int id1)
     {
         color = color1;
         price = price1;
         id = id1;
     }
      public void method2()
      {
         Console.WriteLine("color is:" + color);
         Console.WriteLine("price is:" + price);
         Console.WriteLine("id is:" + id);
     }
}
 class Cars1
 {
     public static void Main()
     {
         Maruti m = new Maruti("red",500000,100);
         m.method1();
         m.Carmethod();
         Mahindra n = new Mahindra("blue",700000,12345);
         n.method2();
         n.Carmethod();
      
     }
 }

