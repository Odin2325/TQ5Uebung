using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace ProgramierenLernen
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int a, b, c , sum;
           Random randNum = new Random(); 
            a= randNum.Next(1,301);  
            b= randNum.Next(1, 301);
            c= randNum.Next(1, 301);

            sum = randomSum(a, b, c);
            Console.WriteLine("Random Sum is : " + sum);

             int randomSum(int a, int b, int c) {
                return a + b + c;  
                       
            }
        }
    }
}

