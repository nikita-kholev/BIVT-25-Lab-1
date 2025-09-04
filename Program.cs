namespace Lab1
{
    public class Program
    {
        public static void Main()
        {
            White white = new White();
            Console.WriteLine(white.Task1(1.2));
            Console.WriteLine(white.Task2(2));
            Console.WriteLine(white.Task3(2, 3));
            Console.WriteLine(white.Task4(-2.5, 1.89));
            Console.WriteLine(white.Task5(0.5));
            Console.WriteLine(white.Task6(2.5, 1.89, 3));
            Console.WriteLine(white.Task7(3));
            Console.WriteLine(white.Task8(2.5, 2, 3));
        }
    }
}
