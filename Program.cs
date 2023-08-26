using System;
using System.ComponentModel.Design;

namespace ConsoleApp1
{

    class Program
    {

        static dynamic input;
        static int row = 0;
        static public void ShowText(string text)
        {
            string bolum = new string('-', 80);
            Console.WriteLine(bolum);
            Console.WriteLine($"                 {text}                     ");
            Console.WriteLine(bolum);

        }
        static public void giris_menusu()
        {
            ShowText("Welcome");
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("        >>Add<<             ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("             Substarction          ");
            Console.WriteLine("             Multiply             ");
            Console.WriteLine("             Division             ");
        }
        
        static public void SetTextColor(string name)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"       >>{name}<<             ");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static public void add( float n1,  float n2)
        {
            Console.Clear();
            ShowText("ADD");

            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        }

        static public void substraction(float n1, float n2)
        {

            Console.Clear();
            ShowText("Substarction");
            Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
        }

        static public void multiply(float n1, float n2)
        {

            Console.Clear();
            ShowText("Multiply");
            Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
        }
        static public void division(float n1, float n2)
        {

            Console.Clear();
            ShowText("Division");
            Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
        }

        static public void inputFromUser(out float num_1, out float num_2)
        {
            Console.Clear();
            Console.Write("Enter number 1: "); num_1 = float.Parse(Console.ReadLine());
            Console.Write("Enter number 2: "); num_2 = float.Parse(Console.ReadLine());
        }

        static void Main()
        { 
            giris_menusu();
            do
            {
                input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (row == 0) row = 3;
                        else row--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (row == 3) row = 0;
                        else row++;
                        break;
                    case ConsoleKey.Enter:
                        switch (row)
                        {
                            case 0:
                                inputFromUser(out float n, out float n2);
                                add(n, n2); break;
                            case 1:
                                inputFromUser(out float num_1, out float num_2);
                                substraction(num_1, num_2); break;
                            case 2:
                                inputFromUser(out float number_1, out float number_2);
                                multiply(number_1, number_2); break;
                            case 3:
                                inputFromUser(out float numm_1, out float numm_2);
                                division(numm_1, numm_2); break;

                        }
                        Console.WriteLine("Press ANY key to go back");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        break;
                    default:
                        break;
                }
                Console.Clear();
                ShowText("Welcome");
                if (row == 0) SetTextColor("Add");
                else Console.WriteLine("             Add             ");
                if (row == 1) SetTextColor("Substraction");
                else Console.WriteLine("             Substraction             ");
                if (row == 2) SetTextColor("Multiply");
                else Console.WriteLine("             Multiply             ");
                if (row == 3) SetTextColor("Division");
                else Console.WriteLine("             Division             ");

            } while (true);

        }
    }
}