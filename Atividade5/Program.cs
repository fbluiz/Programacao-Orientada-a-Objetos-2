using System.IO;
using System;

namespace Atividade5
{
    internal class Program
    {

        static void Main()
        {


            Conta m;
          

            Console.WriteLine("Entre com o número da conta : \n");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titular da conta : \n");
            string titular = Console.ReadLine();
            


            Console.WriteLine("Haverá depósito inicial ? (s/n) \n ");
            char opc = char.Parse(Console.ReadLine());
            if (opc == 's')
           
            {
                Console.WriteLine("Entre com o valor do deposito inicial");
                double deposito = double.Parse(Console.ReadLine());

                m = new Conta(numero, titular, deposito);
                
                Console.WriteLine(m);

                Console.WriteLine("Entre um valor para depósito: \n");
                double deposito2 = double.Parse(Console.ReadLine());
                m.Deposito(deposito2);
                Console.Write("Dados atualizados : \n");
                Console.WriteLine(m);

                Console.WriteLine("Entre um valor para Saque: \n");
                double saque = double.Parse(Console.ReadLine());
                m.Saque(saque);
                Console.WriteLine("Dados atualizados: \n");
                Console.WriteLine(m);

            }

            else
            {
                m = new Conta(numero, titular);
                Console.WriteLine(m);
                
                Console.WriteLine("Entre um valor para depósito: \n");
                double deposito = double.Parse(Console.ReadLine());
                m.Deposito(deposito);
                Console.WriteLine("Dados atualizados : \n");
                Console.WriteLine(m);

                Console.WriteLine("Entre um valor para Saque: \n");
                double saque = double.Parse(Console.ReadLine());
                m.Saque(saque);
                Console.WriteLine("Dados atualizados: \n");
                Console.WriteLine(m);

            }








        }
    }

}