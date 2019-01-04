using System;

namespace hwapp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Are you ready to play rock, paper, scissors?");
      Console.WriteLine("To start, add in your name");
      string playerName = Console.ReadLine();
      Console.WriteLine("Ok let's start!");
      bool playing = true;
      while (playing)
      {
        Console.WriteLine("Choose either rock, paper, or scissors");
        string player = Console.ReadLine();

        Random rnd = new Random();
        string[] pc = { "rock", "paper", "scissors" };
        //generate random indexes for r/p/s
        int pcInd = rnd.Next(pc.Length);
        //display the results
        Console.WriteLine("The PC chose:  {0}", pc[pcInd]);
        if (player == pc[pcInd])
        {
          Console.WriteLine("You and the PC tied");
        }
        else if (player == "rock" && pc[pcInd] == "paper")
        {
          Console.WriteLine($@"You lose {playerName}");
        }
        else if (player == "rock" && pc[pcInd] == "scissors")
        {
          Console.WriteLine($@"You win {playerName}!");
        }
        else if (player == "paper" && pc[pcInd] == "rock")
        {
          Console.WriteLine($@"You win {playerName}!");
        }
        else if (player == "paper" && pc[pcInd] == "scissors")
        {
          Console.WriteLine($@"You lose {playerName}");
        }
        else if (player == "scissors" && pc[pcInd] == "rock")
        {
          Console.WriteLine($@"You lose {playerName}");
        }
        else if (player == "scissors" && pc[pcInd] == "paper")
        {
          Console.WriteLine($@"You win {playerName}!");
        }

        Console.WriteLine("Do you want to play again? Y or N");
        string restart = Console.ReadLine();
        if (restart == "N" || restart == "n")
        {
          playing = false;
        }
      }
    }
  }
}
