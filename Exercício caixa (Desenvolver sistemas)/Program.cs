using System;

namespace Exercício_caixa__Desenvolver_sistemas_
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcoes = 0;
            double saldo = 0;
            while (opcoes != 5)
            {
                opcoes = Menu();
                Console.Clear();
                switch (opcoes)
                {
                    case 1:
                        MostrarSaldo(saldo);
                        break;
                    case 2:
                        saldo = FazerDeposito(saldo);
                        break;
                    case 3:
                        saldo = FazerSaque(saldo);
                        break;
                    case 4:
                        Console.WriteLine("ENCERRANDO PROGRAMA....");
                        break;
                }
            }
            Console.ReadKey();
        }
        static int Menu()
        {
            Console.WriteLine("MENU DE OPÇÕES");
            Console.WriteLine("===================");
            Console.WriteLine("[1] Mostrar Saldo");
            Console.WriteLine("[2] Fazer Deposito");
            Console.WriteLine("[3] Realizar saque");
            Console.WriteLine("[4] Sair");
            int opcoes = int.Parse(Console.ReadLine());
            return opcoes;
        }
        static void MostrarSaldo(double saldo)
        {
            Console.WriteLine("O valor do seu saldo é de R$ " + saldo);
        }
        static double FazerDeposito(double saldo)
        {
            Console.WriteLine("Qual valor você deseja depositar ? ");
            double deposito = double.Parse(Console.ReadLine());
            saldo = saldo + deposito;
            Console.WriteLine("Depósito realizado com sucesso");
            return saldo;
        }
        static double FazerSaque(double saldo)
        {
            Console.WriteLine("Qual valor você deseja sacar ? ");
            double saque = double.Parse(Console.ReadLine());
            if (saldo >= saque)
            {
                saldo = saldo - saque;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Você não tem valor o suficiente");
            }
            return saldo;
        }   
    }
}
    
    

