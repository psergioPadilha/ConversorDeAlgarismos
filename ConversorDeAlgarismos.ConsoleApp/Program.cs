
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
                if (ServicoAlgarismoRomano.VerificarOpcaoCancelar(algarismoRomano))
                    continue;

                List<string> algarismos = ServicoAlgarismoRomano.ValidarDigitosAlgarismoRomano(algarismoRomano);

                List<int> algarismoNumericos = ServicoAlgarismoRomano.PassarDigitosEmRomanoParaDigitosEmIndoArabicos(algarismos);

                List<int> algarismoNumericosInvertidos = ServicoAlgarismoRomano.InverterPosicoesDosAlgarismos(algarismoNumericos);

                ServicoAlgarismoRomano.GerarAlgarismoIndoArabico(algarismoNumericos);
            }
            if (opcao == "2")
            {
                Console.WriteLine("Opção '2' selecionada!");
                Console.ReadKey();
            }

            if ((opcao == "S"))
            {
                if(Menu.MenuSairDoSistema())
                    Environment.Exit(0);
            }
        }
    }
}