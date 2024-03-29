using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DesafioEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar: ");
        veiculos.Add(Console.ReadLine());
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover: ");
        string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
            int horas = Convert.ToInt32(Console.ReadLine());
            decimal valorTotal = precoInicial + (horas * precoPorHora);
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de R$ {valorTotal}");
            veiculos.Remove(placa);
        }
        else
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }

    }


    public void ListarVeiculos()
    {
       if (veiculos != null == veiculos.Any()) 
       {
        Console.WriteLine("Os veículos são:");
        int count = 0;
        foreach(string Total in veiculos)
        {
            count++;
            Console.WriteLine($"Veículo {count} - {Total}");
        }
       }
       else
       {
        Console.WriteLine("Não há veículos estacionados.");
       }
    }

    



    }
}