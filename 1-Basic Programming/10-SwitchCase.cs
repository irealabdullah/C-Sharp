
// Switch main woh match kare ga case se 
// we can write in case [string " ", int 1 , char ''] etc 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter pizza flavour: ");
            string pizza = Console.ReadLine();
            switch (pizza)
            {
                case "Vegetable":
                    Console.WriteLine("Vegetable Selected");
                    break;

                case "Cheese":
                    Console.WriteLine("Cheese Selected");
                    break;

                case "Tikka":
                    Console.WriteLine("Tikka Selected");
                    Console.Write("Select Tikka Spice: ");
                    string Spice = Console.ReadLine();
                    switch (Spice)
                    {
                        case "Spicy":
                            Console.WriteLine("You Have Selected Spicy Pizza");
                            Console.Write("Enter Size Of Pizza:");
                            string size = Console.ReadLine();
                            switch (size)
                            {
                                case "Large":
                                    Console.WriteLine("You Have Selected Large Pizza ");
                                    Console.WriteLine("You Order is dispached");

                                    break;
                                case "Medium":
                                    Console.WriteLine("You Have Selected Medium Pizza");
                                    break;
                                case "Small":
                                    Console.WriteLine("You Have Selected Small Pizza");
                                    break;
                            }

                            break;

                        case "Medium Spicy":
                            Console.WriteLine("You Have Selected Medium Pizza");
                            break;
                        case "Not Spicy":
                            Console.WriteLine("You Have Selected Not Spicy Pizza");
                            break;

                    }


                    break;

                case "Fajitta":
                    Console.WriteLine("Fajjita Selected");
                    break;

                default:
                    Console.WriteLine("Pizza Flavour Not Available");
                    break;

            }

            Console.ReadLine();

        }
    }
}



//Vowel

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any character: ");
            char c = char.Parse(Console.ReadLine());

            switch (c)
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;

                case 'e':
                    Console.WriteLine("Vowel");
                    break;

                case 'i':
                    Console.WriteLine("Vowel");
                    break;

                case 'o':
                    Console.WriteLine("Vowel");
                    break;

                case 'u':
                    Console.WriteLine("Vowel");
                    break;


                default:
                    Console.WriteLine("Consonent");
                    break;
            }

            Console.ReadLine();

        }
    }
}



//Pizza Selection
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Pizza Flavor: ");
            string pizzaName = Console.ReadLine();
           

            switch (pizzaName)
            {
                case "Fajitta":
                    Console.WriteLine("You selected Fajita");
                    Console.WriteLine();

                    Console.WriteLine("Select Fajitta spice");

                    Console.WriteLine("1.Spicy");
                    Console.WriteLine("2.Medium");
                    Console.WriteLine("3.Rare");

                    Console.WriteLine();
                    Console.Write("Spice: ");
                    string spice;
                    spice = Console.ReadLine();
                    

                    switch (spice)
                    {
                        case "Spicy":
                            Console.WriteLine("You selected Spicy");
                            break;

                        case "Medium":
                            Console.WriteLine("You selected Medium ");
                            break;

                        case "Rare":
                            Console.WriteLine("You selected Rare ");
                            break;
                    }

                    break;


                case "Cheese Lover":
                    Console.WriteLine("You selected Cheese Lover ");
                    Console.WriteLine();

                    Console.WriteLine("Select Cheese Lover spice");

                    Console.WriteLine("1.Spicy");
                    Console.WriteLine("2.Medium");
                    Console.WriteLine("3.Rare");

                    Console.WriteLine();
                    Console.Write("Spice: ");
                    spice = Console.ReadLine();


                    switch (spice)
                    {
                        case "Spicy":
                            Console.WriteLine("You selected Spicy");
                            break;

                        case "Medium":
                            Console.WriteLine("You selected Medium ");
                            break;

                        case "Rare":
                            Console.WriteLine("You selected Rare ");
                            break;
                    }
                    break;

                case "Pepperoni":
                    Console.WriteLine("You selected Pepperoni ");
                    Console.WriteLine();

                    Console.WriteLine("Select Pepperoni spice");

                    Console.WriteLine("1.Spicy");
                    Console.WriteLine("2.Medium");
                    Console.WriteLine("3.Rare");

                    Console.WriteLine();
                    Console.Write("Spice: ");           
                    spice = Console.ReadLine();


                    switch (spice)
                    {
                        case "Spicy":
                            Console.WriteLine("You selected Spicy");
                            break;

                        case "Medium":
                            Console.WriteLine("You selected Medium ");
                            break;

                        case "Rare":
                            Console.WriteLine("You selected Rare ");
                            break;
                    }
                    break;


                case "Buffalo":
                    Console.WriteLine("You selected Buffalo ");
                    Console.WriteLine();

                    Console.WriteLine("Select Buffalo spice");

                    Console.WriteLine("1.Spicy");
                    Console.WriteLine("2.Medium");
                    Console.WriteLine("3.Rare");

                    Console.WriteLine();
                    Console.Write("Spice: ");
                    spice = Console.ReadLine();


                    switch (spice)
                    {
                        case "Spicy":
                            Console.WriteLine("You selected Spicy");
                            break;

                        case "Medium":
                            Console.WriteLine("You selected Medium ");
                            break;

                        case "Rare":
                            Console.WriteLine("You selected Rare ");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("No pizza Selected");
                    break;

            }
            Console.ReadLine();

        }
    }
}



// Calculator
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, Ans;
            Console.WriteLine("Welcome to Abdullah's Calculator");
            Console.WriteLine();

            Console.Write("Enter First Integer Number: ");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Enter Second Integer Number: ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Choose Operator: ");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");

            Console.WriteLine();
            char Operator = char.Parse(Console.ReadLine());

            switch (Operator)
            {
                case '+':
                    Ans = num1 + num2;
                    Console.WriteLine("Sum = " + Ans);
                    break;

                case '-':
                    Ans = num1 - num2;
                    Console.WriteLine("Sub = " + Ans);
                    break;

                case '*':
                    Ans = num1 * num2;
                    Console.WriteLine("Multi = " + Ans);
                    break;

                case '/':
                    Ans = num1 / num2;
                    Console.WriteLine("Divi = " + Ans);
                    break;

                default:
                    Console.WriteLine("Try again with Correct instructions");
                    break;
            }

            Console.ReadLine();


        }
    }
}


