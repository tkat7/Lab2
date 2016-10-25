using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string weapon = "Magic";
            string check;
            string name = "******";
            int state = 1;
            while (state != 0)
            {
                switch (state)
                {
                    case 1:
                        Console.Write("What is your name?     ");
                        name = Console.ReadLine();
                        Console.WriteLine();
                        state = 2;
                        break;
                    case 2:
                        Console.Write("Do you want to go on an adventure?     ");
                        check = Console.ReadLine();
                        Console.WriteLine();
                        if (check == "yes" || check == "Yes")
                        {
                            state = 4;
                        }
                        else
                        {
                            state = 3;
                        }
                        break;
                    case 3:
                        Console.WriteLine("GAME OVER");
                        Console.WriteLine();
                        Console.WriteLine("Play again?     ");
                        check = Console.ReadLine();
                        if (check == "yes" || check == "Yes")
                        {
                            state = 1;
                        }
                        else
                        {
                            state = 0;
                        }
                        break;
                    case 4:
                        Console.Write("Would you like a Sword, Bow, or Magic?     ");
                        check = Console.ReadLine();
                        if (check == "Sword" || check == "sword")
                        {
                            weapon = "Sword";
                            Console.WriteLine("You start out on your journey and you come across a fork in the road.");
                            state = 5;
                        }
                        else if (check == "Bow" || check == "bow")
                        {
                            weapon = "Bow";
                            Console.WriteLine("You start out on your journey and you come across a fork in the road.");
                            state = 5;
                        }
                        else if (check == "Magic" || check == "magic")
                        {
                            Console.WriteLine("Sorry there is no such thing as magic.");
                            state = 3;
                        }
                        else
                        {
                            Console.WriteLine("Silly " + name + " that is not a weapon!");
                            state = 4;
                        }
                        break;
                    case 5:
                        Console.Write("Do you go right or left?     ");
                        check = Console.ReadLine();
                        if (check == "Right" || check == "right")
                        {
                            state = 6;
                        }
                        else if (check == "left" || check == "Left")
                        {
                            state = 7;
                        }
                        else
                        {
                            Console.WriteLine("Thats not an option.");
                            state = 5;
                        }
                        break;
                    case 6:
                        Console.WriteLine("You take the path to the left and run into a Giant Eagle.");
                        if (weapon == "Bow")
                        {
                            Console.WriteLine("You shoot the Eagle out of the sky and find treasure hidden in its nest.");
                            state = 8;
                        }
                        else
                        {
                            Console.WriteLine("Your sword is no match for such a beast, The eagle swoops down");
                            Console.WriteLine("and carries you high in the sky before dropping you to your death.");
                            state = 3;
                        }
                        break;
                    case 7:
                        Console.WriteLine("You take the path to the right and run into a King's Knight.");
                        if (weapon == "Sword")
                        {
                            Console.WriteLine("You defeat the knight in an epic battle and take his place");
                            Console.WriteLine("as part of the king's army.");
                            state = 8;
                        }
                        else
                        {
                            Console.WriteLine("Your arrows bounce off the knight's armor as he marches towards you");
                            Console.WriteLine("easily cutting you down with a single swipe.");
                            state = 3;
                        }
                        break;
                    case 8:
                        Console.WriteLine("Congratulations!!!");
                        Console.WriteLine("Play again?     ");
                        check = Console.ReadLine();
                        if (check == "yes" || check == "Yes")
                        {
                            state = 1;
                        }
                        else
                        {
                            state = 0;
                        }
                        break;
                }
            }
        }
    }
}
