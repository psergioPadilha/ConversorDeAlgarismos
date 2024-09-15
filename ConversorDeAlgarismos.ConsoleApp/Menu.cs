using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeAlgarismos.ConsoleApp;

public static class Menu
{
    public static string MenuPrincipal()
    {
        Cabecalho.CabecalhoPrincipal();

        Console.WriteLine("DIGITE UMA OPÇÃO!");
        Console.WriteLine();
        Console.WriteLine("Digite '1' para converter 'ALGARISMO ROMANO' em 'ALGARISMO INDO-ARÁBICO'!");
        Console.WriteLine("Digite '2' para converter 'ALGARISMO INDO-ARÁBICO' em 'ALGARISMO ROMANO'!");
        Console.WriteLine("Digite 'S' para converter 'SAIR DO SISTEMA'!");
        Console.WriteLine();
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();

        string opcaoVerificada = ValidarOpcao(opcao);

        return opcaoVerificada;
    }

    public static string ValidarOpcao(string opcao)
    {
        while ((opcao != "1") && (opcao != "2") && (opcao != "S") && (opcao != "s"))
        {
            Console.WriteLine();
            Console.Write("Opção inválida, por favor digite novamente...");
            Console.ReadKey();
            opcao = MenuPrincipal();
        }

        return opcao;
    }

    public static string MenuConverterAlgarismoRomanoEmAlgarismoIndoArabico()
    {
        Cabecalho.CabecalhoPrincipal();

        Console.WriteLine("Você optou por converter 'ALGARISMO ROMANO' em 'ALGARISMO INDO-ARÁBICO'!");
        Console.WriteLine("Digite o algarismo ou 'R' para retornar!");
        Console.WriteLine();
        Console.Write("Algarismo: ");
        string algarismo = Console.ReadLine();

        return algarismo;
    }

    public static string MenuConverterAlgarismoIndoArabicoEmAlgarismoRomano()
    {
        Cabecalho.CabecalhoPrincipal();

        Console.WriteLine("Você optou por converter 'ALGARISMO INDO-ARÁBICO' em 'ALGARISMO ROMANO'!");
        Console.WriteLine("Digite o algarismo ou 'R' para retornar!");
        Console.WriteLine();
        Console.Write("Algarismo: ");
        string algarismo = Console.ReadLine();

        return algarismo;
    }

    public static bool ConfirmarParaSairDoSistema()
    {
        Cabecalho.CabecalhoPrincipal();

        Console.Write("DESEJA MESMO SAIR DO SISTEMA?");
        Console.ReadKey();
        Console.WriteLine("Digite 'S' para 'SAIR' ou 'C' para 'CANCELAR'!");
        Console.WriteLine();
        Console.Write("Opção: ");

        string opcao = Console.ReadLine();

        string opcaoValidada = ValidarOpcaoDeSair(opcao);

        if ((opcaoValidada == "S") || (opcaoValidada == "s"))
            return true;

        else
            return false;
    }

    public static string ValidarOpcaoDeSair(string opcao)
    {
        while ((opcao != "S") && (opcao != "s") && (opcao != "C") && (opcao != "c"))
        {
            Console.Write("Opção inválida, por favor digite novamente...");

            Cabecalho.CabecalhoPrincipal();

            Console.Write("DESEJA MESMO SAIR DO SISTEMA?");
            Console.ReadKey();
            Console.WriteLine("Digite 'S' para 'SAIR' ou 'C' para 'CANCELAR'!");
            Console.WriteLine();
            Console.Write("Opção: ");

            opcao = Console.ReadLine();
        }

        return opcao;
    }
}