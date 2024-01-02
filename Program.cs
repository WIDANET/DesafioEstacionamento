﻿using DesafioEstacionamento.Models;


Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem-vindo(a) ao sistema de estacionamento! \n" +
                  "Digite o preço: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("[1] - Cadastrar veículo");
    Console.WriteLine("[2] - Remover veículo");
    Console.WriteLine("[3] - Listar veículos");
    Console.WriteLine("[4] - Finalizar programa");
    int escolha = Convert.ToInt32(Console.ReadLine());

    switch(escolha)
    {
        case 1:
            es.AdicionarVeiculo();
            break;

        case 2:
            es.RemoverVeiculo();
            break;

        case 3:
            es.ListarVeiculos();
            break;

        case 4:
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    if (escolha != 4)
    {
        Console.WriteLine("Pressione enter para continuar");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Programa encerrado.");
    }

    
}
