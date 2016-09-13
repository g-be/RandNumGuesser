using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3.NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {          
            Random fun = new Random(); //  random
            string reply = "no";
            bool replay = false;


            do // do while replay = yes
            {
                int secret = fun.Next(0, 1001);// new random
                int guess = -1;
                int max = 250;
                int counter = 1;

                Console.WriteLine("Welcome to the Guessing Game. Try to guess the number between 1 & 1000");

                do // do while guess is wrong
                {   
                    Console.WriteLine("Take a guess");
                    guess = Convert.ToInt32(Console.ReadLine());// get guess

                    if (guess != secret)// if guess is wrong
                    { 
                        if (guess > secret) Console.WriteLine("Wrong. Too high. Attempt # {0} Next Best Guess: {1}", counter++, (guess-max));
                        if (guess < secret) Console.WriteLine("Wrong. Too low.  Attempt # {0} Next Best Guess: {1}", counter++, (guess+max));
                        max /= 2;
                    }

                    else if (guess == secret)// else if guess is right
                    {
                        if (counter < 10) Console.WriteLine("Correct! You got lucky or you know the secret.");
                        if (counter == 10) Console.WriteLine("Correct! You know the secret.");
                        if (counter > 10) Console.WriteLine("Correct! You should be able to do better...");
                    }
                    
                } while (guess != secret);

                Console.WriteLine("Would you like to play again? Y or N");
                reply = Convert.ToString(Console.ReadLine());
                if (reply.Equals("Y") | reply.Equals("y") | reply.Equals("Yes") | reply.Equals("yes") | reply.Equals("1")) 
                    replay = true;
                else 
                    replay = false;
            } while (replay);
        }
    }
}
