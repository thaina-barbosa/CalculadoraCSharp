using System;

namespace ProjetoCalculadoraCSharpe
{
    internal class Program
    {       
        static void Main(string[] args)
        {           
            bool ligado;
            string opcao;
            double resultado = 0;
            string menu = "\n Digite a Opção desejada:\n" +
                             "1 - Multiplicar \n" +
                             "2 - Dividir \n" +
                             "3 - Subtrair \n" +
                             "4 - Somar \n" +
                             "-------------- \n"  +
                             "D - Desligar \n ";

            Console.WriteLine("Digite 'L' Para ligar e 'D' para desligar a calculadora: ");
            opcao = Console.ReadLine();
            ligado = (opcao.ToUpper() != "D");

            while (ligado)
            {  
                //Mostra menu na tela
                Console.WriteLine(menu);

                //Lê opção do usuario
                opcao = Console.ReadLine();

                //Define se calculadora está ligada
                ligado = (opcao.ToUpper() != "D");

                if (!ligado)
                {
                    Console.WriteLine("Desligando calculadora...");
                    break;
                }
                
                Console.WriteLine("Informe os dois numeros da operação");

                switch (opcao)
                {
                    case "1":
                        //Multiplicação                      
                        resultado = Multiplicar(numero: double.Parse(Console.ReadLine()), multiplicador: double.Parse(Console.ReadLine()));                       
                        break;
                    case "2":
                        //Divisão
                        resultado = Dividir(numero: double.Parse(Console.ReadLine()), divisor: double.Parse(Console.ReadLine()));                        
                        break;
                    case "3": 
                        //Subtração
                        resultado = Subtrair(numero: double.Parse(Console.ReadLine()), subtrator: double.Parse(Console.ReadLine()));
                        break;
                    case "4":
                        //Soma
                        resultado = Somar(numero: double.Parse(Console.ReadLine()), somador: double.Parse(Console.ReadLine()));
                        break;
                }
                Console.WriteLine("O Resultado da operação é: " + resultado.ToString());
            }      
        }

        private static double Multiplicar(double numero, double multiplicador)
        {
            return numero * multiplicador;
        }

        private static double Dividir(double numero, double divisor)
        {
            double resultado;

            try
            {
                if (divisor == 0)
                    throw new Exception("Divisor não pode ser 0!");
                else
                    resultado = numero / divisor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resultado = 0;
            }
            return resultado;
        }

        private static double Subtrair(double numero, double subtrator)
        {
            return numero - subtrator;
        }

        private static double Somar(double numero, double somador)
        {
            return numero + somador;
        }
    }
}
