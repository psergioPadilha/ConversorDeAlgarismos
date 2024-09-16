using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConversorDeAlgarismos.Aplicacao.ModuloAlgarismoRomano;

namespace ConversorDeAlgarismos.ConsoleApp;

public static class Menu
{
    public static string MenuPrincipal()
    {
        Cabecalho.CabecalhoPrincipal();

        Console.WriteLine("QUE TIPO DE CONVERSÃO DESEJA REALIZAR!");
        Console.WriteLine();
        Console.WriteLine("Digite '1' para converter 'ALGARISMO ROMANO' em 'ALGARISMO INDO-ARÁBICO'!");
        Console.WriteLine("Digite '2' para converter 'ALGARISMO INDO-ARÁBICO' em 'ALGARISMO ROMANO'!");
        Console.WriteLine("Digite 'S' para 'SAIR DO SISTEMA'!");
        Console.WriteLine();
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();
        string opcaoValidada = ServicoAlgarismoRomano.ValidarOpcaoDeEntradaDoMenuPrincipal(opcao);

        return opcaoValidada;
    }

    public static bool MenuSairDoSistema()
    {
        Cabecalho.CabecalhoPrincipal();

        Console.WriteLine("DESEJA MESMO SAIR DO SISTEMA!");
        Console.WriteLine();
        Console.WriteLine("Digite 'S' para 'SAIR'!");
        Console.WriteLine("Digite 'C' para 'CANCELAR'!");
        Console.WriteLine();
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();
        string opcaoValidada = ServicoAlgarismoRomano.ValidarOpcaoParaSairDoSistema(opcao);

        if ((opcaoValidada == "S") || (opcaoValidada == "s"))
            return true;
        else
            return false;
    }

    public static string MenuConfirmacaoParaSairDoSistema()
    {
        Cabecalho.CabecalhoPrincipal();

        Console.WriteLine("DESEJA MESMO SAIR DO SISTEMA!");
        Console.WriteLine();
        Console.WriteLine("Digite 'S' para 'SAIR'!");
        Console.WriteLine("Digite 'C' para 'CANCELAR'!");
        Console.WriteLine();
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();
        string opcaoValidada = ServicoAlgarismoRomano.ValidarOpcaoParaSairDoSistema(opcao);

        return opcaoValidada;
    }

    public static string MenuConverterAlgarismoRomanoEmAlgarismoIndoArabico()
    {
        Cabecalho.CabecalhoPrincipal();

        Console.WriteLine("VOCÊ OPTOU POR CONVERTER ALGARISMO ROMANO EM ALGARISMO IND-ARÁBICO!");
        Console.WriteLine();
        Console.WriteLine("Digite o 'ALGARISMO ROMANO' ou 'R' para retornar ao menu principal!");
        Console.WriteLine();
        Console.Write("Algarismo: ");
        string algarismo = Console.ReadLine();

        return algarismo;
    }

    public static string MenuConverterAlgarismoAlgarismoIndoArabicoEmRomano()
    {


        return "";
    }
}