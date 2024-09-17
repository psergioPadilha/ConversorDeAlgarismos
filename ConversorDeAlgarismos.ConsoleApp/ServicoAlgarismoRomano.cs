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
        while ((opcao != "S") && (opcao != "C"))
        {
            Mensagens.MensagemOpcaoInvalida();

            opcao = Menu.MenuConfirmacaoParaSairDoSistema();
        }

        return opcao;
    }

    public static bool VerificarOpcaoCancelar(string algarismoRomano)
    {
        bool opcao = false;

        if ((algarismoRomano == "R"))
            opcao = true!;

        return opcao;
    }

    public static List<string> ValidarDigitosAlgarismoRomano(string algarismoRomano)
    {
        List<string> listAlgarismosRomanos = new List<string>();
        int contV = 0;
        int contL = 0;
        int contD = 0;

        for (int i = 0; i < algarismoRomano.Length; i++)
        {
            listAlgarismosRomanos.Add(algarismoRomano[i].ToString());
        }

        for (int i = 0; i < algarismoRomano.Length; i++)
        {
            if ((listAlgarismosRomanos[i] != "I") && (listAlgarismosRomanos[i] != "V") &&
                (listAlgarismosRomanos[i] != "X") && (listAlgarismosRomanos[i] != "L") &&
                (listAlgarismosRomanos[i] != "C") && (listAlgarismosRomanos[i] != "D") &&
                (listAlgarismosRomanos[i] != "M"))
            {
                Mensagens.MensagemDigitoDeAlgarismoInvalido(i, char.Parse(listAlgarismosRomanos[i]));
                listAlgarismosRomanos[i] = Console.ReadLine().ToUpper();

                i -= 1;

                break;
            }

            if ((listAlgarismosRomanos[i] == "V") && (contV == 1))
            {
                Mensagens.MensagemDigitoDeAlgarismoInvalido(i, char.Parse(listAlgarismosRomanos[i]));
                listAlgarismosRomanos[i] = Console.ReadLine().ToUpper();

                i -= 1;

                break;
            }
            else
                contV = 1;

            if ((listAlgarismosRomanos[i] == "L") && (contL == 1))
            {
                Mensagens.MensagemDigitoDeAlgarismoInvalido(i, char.Parse(listAlgarismosRomanos[i]));
                listAlgarismosRomanos[i] = Console.ReadLine().ToUpper();

                i -= 1;

                break;
            }
            else
                contL = 1;

            if ((listAlgarismosRomanos[i] == "D") && (contD == 1))
            {
                Mensagens.MensagemDigitoDeAlgarismoInvalido(i, char.Parse(listAlgarismosRomanos[i]));
                listAlgarismosRomanos[i] = Console.ReadLine().ToUpper();

                i -= 1;

                break;
            }
            else
                contD = 1;

            if (i > 2)
            {
                if ((listAlgarismosRomanos[i] == listAlgarismosRomanos[i - 3]) && 
                    (listAlgarismosRomanos[i] == listAlgarismosRomanos[i - 2]) &&
                    (listAlgarismosRomanos[i] == listAlgarismosRomanos[i - 1]))
                {
                    Mensagens.MensagemDigitoDeAlgarismoInvalido(i, char.Parse(listAlgarismosRomanos[i]));
                    listAlgarismosRomanos[i] = Console.ReadLine().ToUpper();

                    i -= 1;
                }
            }
        }

        return listAlgarismosRomanos;
    }

    public static List<int> PassarDigitosEmRomanoParaDigitosEmIndoArabicos(List<string> listAlgarismoRomano)
    {
        List<int> listNumericos = new List<int>();

        for (int i = 0; i < listAlgarismoRomano.Count; i++)
        {
            if ((listAlgarismoRomano[i] == "i") || (listAlgarismoRomano[i] == "I"))
                listNumericos.Add(1);

            if ((listAlgarismoRomano[i] == "v") || (listAlgarismoRomano[i] == "V"))
                listNumericos.Add(5);

            if ((listAlgarismoRomano[i] == "x") || (listAlgarismoRomano[i] == "X"))
                listNumericos.Add(10);

            if ((listAlgarismoRomano[i] == "l") || (listAlgarismoRomano[i] == "L"))
                listNumericos.Add(50);

            if ((listAlgarismoRomano[i] == "c") || (listAlgarismoRomano[i] == "C"))
                listNumericos.Add(100);

            if ((listAlgarismoRomano[i] == "d") || (listAlgarismoRomano[i] == "D"))
                listNumericos.Add(500);

            if ((listAlgarismoRomano[i] == "m") || (listAlgarismoRomano[i] == "M"))
                listNumericos.Add(1000);
        }

        return listNumericos;
    }


    public static List<int> InverterPosicoesDosAlgarismos(List<int> listNumericos)
    {
        List<int> listNumericosInvertidos = new List<int>();

        int numeroDeElementos = listNumericos.Count();

        for (int i = 0; i < listNumericos.Count; i++)
        {
            listNumericosInvertidos.Add(listNumericos[numeroDeElementos - 1]);

            numeroDeElementos -= 1;
        }

        return listNumericosInvertidos;
    }

    public static void GerarAlgarismoIndoArabico(List<int> listNumericos)
    {
        int algarismoIndoArabico = 0;

        for (int i = 0; i < listNumericos.Count; i++)
        {
            if (i == 0)
                algarismoIndoArabico = listNumericos[i];

            if (i == 1)
            {
                if (listNumericos[i] <= listNumericos[i - 1])
                    algarismoIndoArabico = listNumericos[i] + listNumericos[i - 1];
                else
                {
                    if ((listNumericos[i] == 5) && (listNumericos[i - 1] == 1))
                        algarismoIndoArabico = listNumericos[i] - listNumericos[i - 1];

                    if ((listNumericos[i] == 10) && (listNumericos[i - 1] == 1))
                        algarismoIndoArabico = listNumericos[i] - listNumericos[i - 1];

                    if ((listNumericos[i] == 50) && (listNumericos[i - 1] == 10))
                        algarismoIndoArabico = listNumericos[i] - listNumericos[i - 1];

                    if ((listNumericos[i] == 100) && (listNumericos[i - 1] == 10))
                        algarismoIndoArabico = listNumericos[i] - listNumericos[i - 1];

                    if ((listNumericos[i] == 500) && (listNumericos[i - 1] == 100))
                        algarismoIndoArabico = listNumericos[i] - listNumericos[i - 1];

                    if ((listNumericos[i] == 1000) && (listNumericos[i - 1] == 100))
                        algarismoIndoArabico = listNumericos[i] - listNumericos[i - 1];
                }
            }

            if (i == 2)
            {
                if ((listNumericos[i - 2] >= listNumericos[i - 1]) && (listNumericos[i - 1] >= (listNumericos[i])))
                    algarismoIndoArabico = listNumericos[i - 2] + listNumericos[i - 1] + listNumericos[i];

                if ((listNumericos[i - 2] >= listNumericos[i - 1]) && (listNumericos[i - 1] < (listNumericos[i])))
                    algarismoIndoArabico = listNumericos[i - 2] + (listNumericos[i] - listNumericos[i -1]);

                if ((listNumericos[i - 2] < listNumericos[i - 1]) && (listNumericos[i - 1] > (listNumericos[i])))
                    algarismoIndoArabico = (listNumericos[i - 1] - (listNumericos[i - 2]) + listNumericos[i]);
            }
        }

        Console.WriteLine("Algarismo indo-arábico: " + algarismoIndoArabico);
        Console.ReadKey();
    }
}