
using System.ComponentModel.Design;

namespace ConversorDeAlgarismos.ConsoleApp;
internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string opcao = Menu.MenuPrincipal();

            if (opcao == "1")
            {
                string algarismoRomano = Menu.MenuConverterAlgarismoRomanoEmAlgarismoIndoArabico();
                if(ServicoAlgarismoRomano.VerificarOpcaoCancelar(algarismoRomano))
                    break;

                List<string> algarismos = ServicoAlgarismoRomano.ValidarAlgarismoRomano(algarismoRomano);

            }
            if (opcao == "2")
            {
                Console.WriteLine("Opção '2' selecionada!");
                Console.ReadKey();
            }

            if ((opcao == "S") || (opcao == "s"))
            {
                if(Menu.MenuSairDoSistema())
                    Environment.Exit(0);
            }
        }
    }
}