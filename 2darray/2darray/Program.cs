using System;

namespace _2darray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ray = {
                {"", "", ""},
                {"", "", ""},
                {"", "", ""}
            };

            bool quit = false;
            while (quit == false)
            {
                for (int var = 0; var < 3; var++)
                {
                    //Console.WriteLine(var);
                    for (int i = 0; i <= 2; i++)
                    {
                        //Console.WriteLine("   "+i);
                        Console.Write("[");
                        if (ray[var, i] == "")
                        {
                            Console.Write(" ");
                        }
                        Console.Write(ray[var, i]);
                        Console.Write("]");
                        Console.Write(" ");
                    }
                    Console.Write("\n");
                }

                Console.Write("\n\nWhat will x do, Y: ");
                int Yval = System.Convert.ToInt32(Console.ReadLine());
                
                Console.Write("What will x do, X: ");
                int Xval = System.Convert.ToInt32(Console.ReadLine());


                ray[Yval, Xval] = "X";

                Console.WriteLine("Quit?");

                if (Console.ReadLine() == "yes")
                {
                    quit = true;
                }
            }




            Console.ReadLine();
        }
    }
}
