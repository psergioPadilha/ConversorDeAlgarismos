using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeAlgarismos.ConsoleApp;

public class Mensagens
{
    public static void MensagemOpcaoInvalida()
    {
        Cabecalho.CabecalhoPrincipal();
        Console.Write("Opção inválida, por favor informe novamente...");
        Console.ReadKey();
    }

    public static void MensagemConfirmacaoParaSairDoSistema()
    {
        Cabecalho.CabecalhoPrincipal();
        Console.Write("DESEJA MESMO SAIR DO SISTEMA?");
        Console.ReadKey();
    }

    public static void MensagemDigitoDeAlgarismoInvalido(int posicao, char digito)
    {
        Console.WriteLine();
        Console.Write($"Dígito '{digito}' inserido na posicao '{posicao + 1}' não equivale a um 'ALGARISMO VÁLIDO', por favor insira outro valor válido!");
        Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine("Por favor insira outro 'ALGARISMO' válido!");
        Console.Write("Algarismo: ");
    }
}