using System;

namespace ReversePolishNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            ReversePolishNotation rpn = new ReversePolishNotation();
            string test = "p q r s ∨ →";
            if (rpn.validateFormula(test))
            {
                if(rpn.parseFormula( rpn.tokenizeInput(test) )) Console.WriteLine("Funciona");
                else Console.WriteLine("No funciona");
            }

            //Esto deberia decir que es valido

            int entrada = 0;
            string valor;
            string[] pruebas = { "", "", "", "", "", "" };
            Random rng = new Random();
            while (true)
            {
                Console.WriteLine("Bienvenido al validador de formulas proposicionales");
                Console.WriteLine("1. Casos de Prueba");
                Console.WriteLine("2. Insertar una formula proposicional");
                Console.WriteLine("3. terminar sesion");
                if (entrada == 1)
                {
                    rng.Next(0, 7);
                }
                if (entrada == 2)
                {
                    valor = Console.ReadLine();
                    Console.WriteLine(valor.ToLower());
                }
                if (entrada == 3)
                {
                    break;
                }
            }
        }
    }
}