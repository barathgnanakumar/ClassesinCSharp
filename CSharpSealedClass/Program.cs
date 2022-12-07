using System;
using System.IO;
namespace SealedClass
{
    sealed class Sealed
    {
        int a, b;
        public void add(int a, int b)
        {
            this.a = a;
            this.b = b;
            int c = a + b;
            Console.WriteLine("Sum of Two Numbers : " + c);
        }
    }
    /*public class NewSeal : Sealed
    {
        int a, b;
        public void multiply(int a, int b)
        {
            this.a = a;
            this.b = b;
            int c = a * b;
            Console.WriteLine("Two Numbers Multiplied : " + c);
        }
    }*/
    public class Program
    {
        static void Main(string[] args)
        {
            Sealed seal = new Sealed();
            seal.add(5, 3);
       //   seal.multiply(5, 3);
            Console.ReadKey();
        }
    }
}