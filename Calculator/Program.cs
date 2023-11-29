using System.Runtime.CompilerServices;

class calc
{
    static void Main()
    {
        Console.WriteLine("Hi do you want to calculate something?");
        Console.WriteLine("y for yes and n for no");
        var Menuinput = Console.ReadLine();

        if (Menuinput == "y")
        {
            do
            {
            int Result = 0;
            int Calcchoice;
            int Number1;
            int Number2;
            Console.WriteLine("Write the first number");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out Number1))
                {
                Console.WriteLine("First number is" + " " + Number1);
                break;
                }
                else
                {
                Console.WriteLine("Not a number, try again");
                }
            }
            Console.WriteLine("Which of the following functions do you wish to use?");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");

            while(true)
            {
                int.TryParse(Console.ReadLine(), out Calcchoice);
                if (Calcchoice < 5 && Calcchoice > 0)
                {
                    break;

                }
                else
                {
                    Console.WriteLine("Not a number or wrong number choice");
                }
            }
           
            
            Console.WriteLine("Now write the second number");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out Number2))
                {
                Console.WriteLine("Second number is" + " " + Number2);
                break;
                }
                else
                {
                Console.WriteLine("Not a number, try again");
                }
            }

            switch(Calcchoice)
            {
                case 1:
                   Result = Number1 + Number2;
                 break;
                case 2:
                   Result = Number1 - Number2;
                 break;
                case 3:
                    Result = Number1 * Number2;
                 break;
                case 4:
                    Result = Number1 / Number2;
                 break;
                default:

                 break;
            }

               if (Calcchoice == 1)
               {
                    Console.WriteLine("The result of your calculation is " + " " + Number1 + " " + "+" + " " + Number2 + " " + "=" + " " + Result);
               }
               else if (Calcchoice == 2)
               {
                    Console.WriteLine("The result of your calculation is " + " " + Number1 + " " + "-" + " " + Number2 + " " + "=" + " " + Result);
               }
               else if (Calcchoice == 3)
               {
                    Console.WriteLine("The result of your calculation is " + " " + Number1 + " " + "*" + " " + Number2 + " " + "=" + " " + Result);
               }
               else if (Calcchoice == 4)
               {
                    Console.WriteLine("The result of your calculation is " + " " + Number1 + " " + "/" + " " + Number2 + " " + "=" + " " + Result);
               }
                Console.ReadLine();
                Console.WriteLine("Want to do another calculation? y or n");
                var input = Console.ReadLine();
                if (input == "y")
                {
                    Console.WriteLine("Great");
                }
                if (input == "n")
                {
                    break;
                }
            } 
            while (true);

        }

        else
        {
            Console.WriteLine("That's a shame, goodbye!");

        }
        




    }

}