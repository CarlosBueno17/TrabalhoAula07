﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3TrabalhoAula07
{
    internal class Program
    {
        private static double saldoCliente = 0.0;
        static void Main(string[] args)
        {
            bool reiniciarSistema = true; 

            while (reiniciarSistema)
            {
                Console.WriteLine("Bem-vindo à Máquina de Café!!!");

                Console.Write("Insira o valor que deseja depositar: ");
                double valorDepositado = Convert.ToDouble(Console.ReadLine());

                saldoCliente += valorDepositado; 

                Console.WriteLine("\nOpções de café:");
                Console.WriteLine("1. Café expresso - R$ 3,00");
                Console.WriteLine("2. Cappuccino - R$ 4,50");
                Console.WriteLine("3. Mocaccino - R$ 6,00");
                Console.WriteLine("4. Água quente - R$ 1,00");

                Console.Write("\nEscolha a opção de café desejada (1-4): ");
                int opcaoCafe = Convert.ToInt32(Console.ReadLine());

                double precoCafe = 0.0;
                string nomeCafe = "";

                switch (opcaoCafe)
                {
                    case 1:
                        precoCafe = 3.00;
                        nomeCafe = "Café expresso";
                        break;
                    case 2:
                        precoCafe = 4.50;
                        nomeCafe = "Cappuccino";
                        break;
                    case 3:
                        precoCafe = 6.00;
                        nomeCafe = "Mocaccino";
                        break;
                    case 4:
                        precoCafe = 1.00;
                        nomeCafe = "Água quente";
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Reiniciando o sistema...");
                        continue;
                }

                if (saldoCliente >= precoCafe)
                {
                    double troco = saldoCliente - precoCafe;
                    Console.WriteLine($"Preparando {nomeCafe}. Retire seu café. Troco: R$ {troco:F2}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente. Reiniciando o sistema...");
                    continue;
                }

                Console.Write("\nDeseja atender ao próximo cliente? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();// converte um caracter para sempre sair em formato maiúsculo 

                if (resposta != "S")
                {
                    reiniciarSistema = false;
                }

                saldoCliente = 0.0; // Reinicia o saldo do cliente
                Console.Clear();
            }
        }
    }
}
    

