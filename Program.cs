using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
      Console.Write("Enter a Number");
      double num1 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter Oparator");
      String oparator = Console.ReadLine();

      Console.Write("Enter another Number :");
      double num2 = Convert.ToDouble(Console.ReadLine());

      if (oparator == "+")
      {

        Console.WriteLine(num1 + num2);

      }
      else if (oparator == "-")
      {
        Console.WriteLine(num1 - num2);

      }
      else if (oparator == "*")
      {
        Console.WriteLine(num1 * num2);

      }
      else if (oparator == "/")
      {
        Console.WriteLine(num1 / num2);

      }
      else {
        Console.WriteLine("Invalid Selection");
      }


    }
    }
}
