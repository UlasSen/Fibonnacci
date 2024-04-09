internal class Program
{
    private static void Main(string[] args)
    {
        Fib(10);
    }

    //Solution A
    public static void Fib(int x)
        {
            int fib1 = 0;
            int fib2 = 1;
            for (int i = 1;i<=x;i++)
            {
                int fib3 = fib1;
                fib1=fib1 + fib2;
                fib2 = fib3;
            }
            Console.WriteLine(fib2);

        }

    //Solution B
    /*public static void Fib(int x)
    {
        //0 1 1 2 3 5 8 13 21 34 55 89...
        int fib1 = 1;
        int fib2=1;
        int fib3;
        if (x == 1)
        {
            Console.WriteLine("0");
            return;
           
        }
        if (x == 2)
        {
            Console.WriteLine("1");
            return;
        }

        for(int i = 3; i <= x; i++)
        {
            fib3= fib1;
            fib1 = fib1 + fib2;
            fib2 = fib3;

        }
        Console.WriteLine(fib2);


    }*/
    
}