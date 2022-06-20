using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Binary: "); //Prompt the user to enter a binary number that they want to convert into a decimal (base 10) number.
    string input = Console.ReadLine();
    Console.WriteLine("{0}", Convert.ToInt32(input,2));
    Console.Readline();
  }
}
