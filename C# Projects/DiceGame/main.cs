using System;

namespace SimpleDiceGame
{
  class Program
  {
    static void Main (string[] args)
    {
      int playerRandomNum;
      int enemyRandomNum;
    
      int playerPoints = 0;
      int enemyPoints = 0;
    
      Random random = new Random();
    
      for(int i = 0; i < 10; i++) //Play the game for 10 rounds.
      {
        Console.WriteLine("Press any key to roll the dice!");
      
        Console.ReadKey();
      
        playerRandomNum = random.Next(1, 7);
        Console.WriteLine("You rolled a " + playerRandomNum);
      
        Console.WriteLine("...");
        System.Threading.Thread.Sleep(1000); //Make things feel nice with a short wait time between player and enemy dice rolls.
      
        enemyRandomNum = random.Next(1, 7);
        Console.WriteLine("The Enemy rolled a " + enemyRandomNum);
      
        if(playerRandomNum > enemyRandomNum)
        {
          playerPoints++;
          Console.WriteLine("You win this round!");
        }
        else if(enemyRandomNum > playerRandomNum)
        {
          enemyPoints++;
          Console.WriteLine("The Enemy wins this round!");
        }
        else
        {
          Console.WriteLine("This round's a draw!");
        }

        Console.WriteLine("The score is now - Player: " + playerPoints + ". Enemy: " + enemyPoints + "."); //Report the current score to the user.
        Console.WriteLine(); //Empty line to make things look nice.
      }
    
      if(playerPoints > enemyPoints)
      {
        Console.WriteLine("You Win!");
      }
      else if(enemyPoints > playerPoints)
      {
        Console.WriteLine("You Lose!");
      }
      else
      {
        Console.WriteLine("It's a draw!");
      }
    
      Console.ReadKey();
    }
  }
}
