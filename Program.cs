﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random random = new Random();

            int EasyLevel = random.Next(1, 10);
            int MediumLevel = random.Next(1, 20);
            int HardLevel = random.Next(1, 50);
            int Guess = 0;

           Console.WriteLine("Welcome to the Number Guessing Game.");
           Console.WriteLine("Kindly select the difficulty of your choice: Enter 1 for Easy, 2 for Medium or 3 for Hard");
           Console.Write("Select Your Preferred Difficulty Level: ");

           int Level = int.Parse(Console.ReadLine());

           if (Level == 1){

               Console.WriteLine("Welcome to Diffculty Level: EASY");
               int count = 1;

               
               for (int i = 0; i < 6; i++){

                   Console.Write("Enter a guess: ");
               Guess = int.Parse(Console.ReadLine());

                     if ( Guess != EasyLevel)
                   {
                       Console.WriteLine("That was wrong! Make another guess");
                       ++count;
                       continue;
                       
                   }
                   else if (Guess == EasyLevel){

                       Console.WriteLine("You got it right! The number was " + EasyLevel);
                       Console.WriteLine("It took you {0} {1}.\n", count, 
                                           count == 1 ? "try" : "tries");
                                           break; 
                   }
                   else
                   {
                       Console.WriteLine("Gameover {0} {1}.\n", count, 
                                           count == 6 ? "try" : "tries");
                                           break;
                   }
                       
                   
               }
           }

           else if (Level == 2){

               Console.WriteLine("Welcome to Diffculty Level: MEDIUM");
               int count = 1;

               
               for (int i = 0; i < 4; i++){

                   Console.Write("Enter a guess: ");
               Guess = int.Parse(Console.ReadLine());

                     if ( Guess != MediumLevel)
                   {
                       Console.WriteLine("That was wrong! Make another guess");
                       ++count;
                       continue;
                       
                   }
                   else if (Guess == MediumLevel){

                       Console.WriteLine("You got it right! The number was " + MediumLevel);
                       Console.WriteLine("It took you {0} {1}.\n", count, 
                                           count == 1 ? "try" : "tries");
                                           break;
                       
                   }
                  else
                   {
                       Console.WriteLine("Gameover {0} {1}.\n", count, 
                                           count == 4 ? "try" : "tries");
                                           break;
                   }
               }
           }

            else if (Level == 3){

               Console.WriteLine("Welcome to Diffculty Level: HARD");
               int count = 1;

               
               for (int i = 0; i < 3; i++){

                   Console.Write("Enter a guess: ");
               Guess = int.Parse(Console.ReadLine());

                     if ( Guess != HardLevel)
                   {
                       Console.WriteLine("That was wrong! Make another guess");
                       ++count;
                       continue;
                       
                   }
                   else if (Guess == HardLevel){

                       Console.WriteLine("You got it right! The number was " + HardLevel);
                       Console.WriteLine("It took you {0} {1}.\n", count, 
                                           count == 1 ? "try" : "tries");
                                           break;
                       
                   }
                  else
                   {
                       Console.WriteLine("Gameover {0} {1}.\n", count, 
                                           count == 3 ? "try" : "tries");
                                           break;
                   }
               }
           }

           else
           {
               Console.WriteLine("You Selected an invalid option. No such stage exists");
               return;
           }


        }
    }
}