using System;
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
               Console.WriteLine("Make a guess of the number between 1 and 10");
               Console.WriteLine("You have 6 guesses only");
               int count = 1;

               
               for (int i = 0; i < 6; i++){

                   Console.Write("Enter a guess: ");
               Guess = int.Parse(Console.ReadLine());


               //STAGE 1 OR EASY STAGE CODE

                     if ( Guess != EasyLevel)
                   {
                        if (count < 6)
                        {

                            Console.WriteLine("That was wrong! Make another guess");
                            Console.WriteLine("You have made {0} {1}.\n", count, 
                                           count == 1  ? "try" : "tries");
                            Console.WriteLine("You have {0} {1}.\n", 6 - count, 
                                           count == 5  ? "try left" : "tries left");    
                            ++count;

                        }
                       
                       else 
                       {

                           Console.WriteLine("That was wrong! Gameover!");
                           Console.WriteLine("You have made {0} {1}.\n", count, 
                                           count == 1  ? "tries" : "tries");
                                       
                            break;
                       }
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
                       return;
                   }
                   
               }
           }
            
            //STAGE 2 OR MEDIUM STAGE CODE
           else if (Level == 2){

               Console.WriteLine("Welcome to Diffculty Level: MEDIUM");
               Console.WriteLine("Make a guess of the number between 1 and 20");
               Console.WriteLine("You have 4 guesses only");
               int count = 1;

               
               for (int i = 0; i < 4; i++){

                   Console.Write("Enter a guess: ");
               Guess = int.Parse(Console.ReadLine());

                     if ( Guess != MediumLevel)
                   {
                        if (count < 4)
                        {

                            Console.WriteLine("That was wrong! Make another guess");
                            Console.WriteLine("You have made {0} {1}.\n", count, count == 1  ? "try" : "tries");
                            Console.WriteLine("You have {0} {1}.\n", 4 - count, count == 3  ? "try left" : "tries left"); 
                            ++count;

                        }
                       
                       else 
                       {

                           Console.WriteLine("That was wrong! Gameover!");
                           Console.WriteLine("You have made {0} {1}.\n", count, 
                                           count == 4  ? "tries" : "tries");
                            break;
                       }
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
                       return;
                   }    
                                           
                   
               }
           }

           //STAGE 3 OR HARD STAGE CODE

            else if (Level == 3){

               Console.WriteLine("Welcome to Diffculty Level: HARD");
               Console.WriteLine("Make a guess of the number between 1 and 50");
               Console.WriteLine("You have 3 guesses only");
               int count = 1;

               
               for (int i = 0; i < 4; i++){

                   Console.Write("Enter a guess: ");
               Guess = int.Parse(Console.ReadLine());

                     if ( Guess != HardLevel)
                   {
                        if (count < 3)
                        {

                            Console.WriteLine("That was wrong! Make another guess");
                            Console.WriteLine("You have made {0} {1}.\n", count, count == 1  ? "try" : "tries");
                            Console.WriteLine("You have {0} {1}.\n", 3 - count, count == 2  ? "try left" : "tries left"); 
                            ++count;

                        }
                       
                       else 
                       {

                           Console.WriteLine("That was wrong! Gameover!");
                           Console.WriteLine("You have made {0} {1}.\n", count, 
                                           count == 4  ? "tries" : "tries");
                            break;
                       }
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
                       return;
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
