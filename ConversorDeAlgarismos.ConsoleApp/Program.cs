
using System.ComponentModel.Design;

namespace ConversorDeAlgarismos.ConsoleApp;
internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string algarismoRomano;

            string opcao = Menu.MenuPrincipal();

            if (opcao == "1")
                algarismoRomano = Menu.MenuConverterAlgarismoRomanoEmAlgarismoIndoArabico();
            if (opcao == "2")
                algarismoRomano = Menu.MenuConverterAlgarismoIndoArabicoEmAlgarismoRomano();
            if (Menu.ConfirmarParaSairDoSistema())
                Environment.Exit(0);
            else
                continue;


            Console.ReadKey();
        }
    }
}