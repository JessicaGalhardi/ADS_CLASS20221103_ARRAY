using System;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {
        try
        {
            int[] numbers = new int[8];

            numbers[0] = 100;
            numbers[1] = 200;
            numbers[2] = 250;
            numbers[3] = 400;
            numbers[4] = 480;
            numbers[5] = 500;
            numbers[6] = 520;
            numbers[7] = 1000;
           

            Console.WriteLine("The number in position 0 is: " + numbers[0]);
            Console.WriteLine("The number in position 1 is: " + numbers[1]);
            Console.WriteLine("The number in position 2 is: " + numbers[2]);
            Console.WriteLine("The number in position 3 is: " + numbers[3]);
            Console.WriteLine("The number in position 4 is: " + numbers[4]);
            Console.WriteLine("The number in position 5 is: " + numbers[5]);
            Console.WriteLine("The number in position 6 is: " + numbers[6]);
            Console.WriteLine("The number in position 7 is: " + numbers[7]);
           
            Console.ReadKey();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while running the application" + ex);

        }
    }
}
