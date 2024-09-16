using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeAlgarismos.ConsoleApp;
public class ServicoAlgarismoRomano
{
    public static string ValidarOpcaoDeEntradaDoMenuPrincipal(string opcao)
    {
        while ((opcao != "1") && (opcao != "2") && (opcao != "S") && (opcao != "s"))
        {
            Mensagens.MensagemOpcaoInvalida();
            opcao = Menu.MenuPrincipal();
        }

        return opcao;
    }

    public static string ValidarOpcaoParaSairDoSistema(string opcao)
    {
        while ((opcao != "S") && (opcao != "s") && (opcao != "C") && (opcao != "c"))
        {
            Mensagens.MensagemOpcaoInvalida();

            opcao = Menu.MenuConfirmacaoParaSairDoSistema();
        }

        return opcao;
    }

    public static bool VerificarOpcaoCancelar(string algarismoRomano)
    {
        bool opcao = false;

        if ((algarismoRomano == "R") || (algarismoRomano == "r"))
            opcao = true!;

        return opcao;
    }

    public static List<string> ValidarAlgarismoRomano(string algarismoRomano)
    {
        List<string> listAlgarismosRomanos = new List<string>();

        for (int i = 0; i < algarismoRomano.Length; i++)
        {
            listAlgarismosRomanos.Add(algarismoRomano[i].ToString());
        }

        for (int i = 0; i < algarismoRomano.Length; i++)
        {
            if ((listAlgarismosRomanos[i] != "i") && (listAlgarismosRomanos[i] != "I") &&
                (listAlgarismosRomanos[i] != "v") && (listAlgarismosRomanos[i] != "V") &&
                (listAlgarismosRomanos[i] != "x") && (listAlgarismosRomanos[i] != "X") &&
                (listAlgarismosRomanos[i] != "l") && (listAlgarismosRomanos[i] != "L") &&
                (listAlgarismosRomanos[i] != "c") && (listAlgarismosRomanos[i] != "C") &&
                (listAlgarismosRomanos[i] != "d") && (listAlgarismosRomanos[i] != "D") &&
                (listAlgarismosRomanos[i] != "m") && (listAlgarismosRomanos[i] != "M")
               )
            {
                Mensagens.MensagemDigitoDeAlgarismoInvalido(i, char.Parse(listAlgarismosRomanos[i]));
                listAlgarismosRomanos[i] = Console.ReadLine();

                i -= 1;
            }
        }

        return listAlgarismosRomanos;
    }

    public static void PassarDigitosEmRomanoParaDigitosEmIndoArabicos(List<string> listAlgarismoRomano)
    {
        List<int> listAlgarismosIndoArabicos = new List<int>();

        for (int i = 0; i < listAlgarismoRomano.Count; i++)
        {
            if ((listAlgarismoRomano[i] == "i") || (listAlgarismoRomano[i] == "I"))
                listAlgarismosIndoArabicos.Add(1);

            if ((listAlgarismoRomano[i] == "v") || (listAlgarismoRomano[i] == "V"))
                listAlgarismosIndoArabicos.Add(5);

            if ((listAlgarismoRomano[i] == "x") || (listAlgarismoRomano[i] == "X"))
                listAlgarismosIndoArabicos.Add(10);

            if ((listAlgarismoRomano[i] == "l") || (listAlgarismoRomano[i] == "L"))
                listAlgarismosIndoArabicos.Add(50);

            if ((listAlgarismoRomano[i] == "c") || (listAlgarismoRomano[i] == "C"))
                listAlgarismosIndoArabicos.Add(100);

            if ((listAlgarismoRomano[i] == "d") || (listAlgarismoRomano[i] == "D"))
                listAlgarismosIndoArabicos.Add(500);

            if ((listAlgarismoRomano[i] == "m") || (listAlgarismoRomano[i] == "M"))
                listAlgarismosIndoArabicos.Add(1000);
        }
    }
}