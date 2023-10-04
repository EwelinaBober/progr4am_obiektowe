using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1.Sprawdz czy liczba jest parzysta i nie parzysta");
                Console.WriteLine("2 Liczba parzysta");

                var input = Console.ReadLine();

                switch (let.Parse(input));
                {
                    case 1:
                        DisplayNumberIsEven();
                    break;
                    case 2:
                        break;
                    case 0: return;

                }


            }

        }

        static void Game()
        {
            var random = new Random();
            var number = Random.Next(1, 101,);//1-100

            int count = 0;
            int shoot;
            do
            {
                count++;
                Console.WriteLine("Podaj liczbe")
                var input = Console.ReadLine();

                shoot = int.Parse(input);
            }
            while (shoot 1=number);

            Console.WriteLine($"Zgadłes za{count}");
        }   


        

        static void DisplayNumberIsEven()
        {
            Console.WriteLine("Podaj liczbe:");
            var input = Console.Readline();
            if (int.Parse(input) % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzytsa");
            }
            else
            {
                Console.WriteLine("liczab jest nieparzysta");
            }

        }


                  
         static bool NumberIsEven ()  

                



                



                


            
        
    }
}
