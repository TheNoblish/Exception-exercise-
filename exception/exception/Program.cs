
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
class Program 
{ 
    static void Main(string[] args) 
    { 
        int num1, num2; 
        byte result; 
        num1 = 30; 
        num2 = 60;
        try
        {
            result = Convert.ToByte(num1 * num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
        }
        catch ( OverflowException )
        {
            Console.WriteLine("Exception: {0} (the numbers multiplied) > {1} (maximum value of byte type)", num1 * num2, byte.MaxValue);
        }
        Console.ReadLine(); 
    } 
} 
