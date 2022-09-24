using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Menu();

        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escola uma opcao");

            Console.WriteLine("1 é a soma");
            Console.WriteLine("2 é a subtração");
            Console.WriteLine("3 é a multiplicação");
            Console.WriteLine("4 é a divisao");

            short escolha = short.Parse(Console.ReadLine());

            switch(escolha)
            {
              case 1: {
                    Soma(); break;}

                case 2: {
                    Subtracao();
                    break;
                }
                case 3 :
                {
                    Divisao();
                    break;
                }
                case 4 :
                {
                    Multiplicacao();
                    break;
                }
                default :
                {
                    Menu();
                    break;
                }
            }

        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo valor: ");
            var v2 = float.Parse(Console.ReadLine());


            Console.WriteLine("");

            float resultado = v1 + v2;
            // Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da soma é {resultado}");

                        Menu();


        }
    
       static void Subtracao()
                {
        Console.Clear();

        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 - v2;
        Console.WriteLine($"O resultado da subtração é {resultado}");
        Console.ReadKey();
                    Menu();

     }

     static void Divisao()
     {
        Console.Clear();

        Console.WriteLine("Primeiro Valor");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine($"O resultado é {v1/v2}");
                    Menu();

     }

     static void Multiplicacao()
     {
        Console.Clear();
        
        Console.WriteLine("Primeiro valor");
        float v1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Segundo valor");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("O resultado é" + (v1*v2));
            Menu();

     }
    }
     
}
