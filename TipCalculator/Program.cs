using System;

class Program
{
    static void Main()
    {
        string welcomingString = "Welcome to the Tip Calculator!";
        Console.WriteLine(welcomingString);



      Console.Write("Please input total amount of your bill here, and then press Enter: $ ");
      decimal inputAmount = decimal.Parse(Console.ReadLine());



      Console.Write("Please select the tip percentage: 15%, 18% or 20%? ");
      decimal inputPercentage = decimal.Parse(Console.ReadLine());



      decimal totalAmount = inputAmount + (inputAmount * (inputPercentage / 100));


      Console.WriteLine("The total bill amount is: ${0}", inputAmount);

      Console.WriteLine("The percentage selected is: {0}%", inputPercentage);

      Console.WriteLine("The total amount to be paid is: ${0}", totalAmount);



      Console.ReadLine();

    }
}






