
internal class Program
{
   /* private static void Main(string[] args)
    {
        //Console.Write("Hello World!");
        //Console.WriteLine("Congratulation!");
        //Console.Write("This is my first line off code!");
        Console.Write()
    }
    */
    static void Main(string[] args)
    {
        Demoaddition();
        DemoSubtraction();
        DemoMultition();
        DemoDevision();
    }
    static void Demoaddition()
    {
        int x=1;
        int y=2;
        int z=x+y;
        Console.WriteLine($"x={x}");
        Console.WriteLine($"y={y}");
        Console.WriteLine($"z=x+y={z}");
    }
    static void DemoSubtraction()
    {
        int x=1;
        int y=2;
        int z=x-y;
        Console.WriteLine($"x={x}");
        Console.WriteLine($"y={y}");
        Console.WriteLine($"z=x-y={z}");
    }
       static void DemoMultition()
    {
        int x=1;
        int y=2;
        int z=x*y;
        Console.WriteLine($"x={x}");
        Console.WriteLine($"y={y}");
        Console.WriteLine($"z=x*y={z}");
    }
     static void DemoDevision()
    {
        int x=1;
        int y=2;
        float z=x/(float)y;
        Console.WriteLine($"x={x}");
        Console.WriteLine($"y={y}");
        Console.WriteLine($"z=x/y={z}");
    }
}