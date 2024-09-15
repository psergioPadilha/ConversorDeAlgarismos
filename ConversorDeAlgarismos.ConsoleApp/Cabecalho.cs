using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeAlgarismos.ConsoleApp;

public static class Cabecalho
{
    public static void CabecalhoPrincipal()
    {
        string instituicao = "ACADEMIA DO PROGRAMADOR!!!";
        string turma = "TURMA 2024";
        string mensagem = "Programa Conversor de Algarismos";

        Console.Clear();

        // Primeira linha

        // Imprime a primeira linha do cabeçalho
        for (int i = 1; i <= 60; i++)
        {
            Console.Write("*");
        }

        // Quebra para segunda linha
        Console.WriteLine();

        // Imprime '*' no início da segunda linha
        Console.Write("*");

        // Imprime espaços em branco na segunda linha antes do valor da variavel 'instituicao'
        for (int i = 1; i <= ((60 - instituicao.Length) / 2) -1; i++)
        {
            Console.Write(" ");
        }

        // Imprime na segunda linha o valor da variável 'instituicao'
        Console.Write(instituicao);

        // Imprime espaços em branco após do valor da variavel 'instituicao'
        for (int i = 1; i <= ((60 - instituicao.Length) / 2) - 1; i++)
        {
            Console.Write(" ");
        }

        // Imprime '*' no final da segunda linha e quebra para terceira linha
        Console.WriteLine("*");


        // Terceira linha

        // Imprime '*' no início da terceira linha
        Console.Write("*");

        // Imprime espaços em branco na terceira linha antes do valor da variavel 'turma'
        for (int i = 1; i <= ((60 - turma.Length) / 2) - 1; i++)
        {
            Console.Write(" ");
        }

        // Imprime na terceira linha o valor da variável 'turma'
        Console.Write(turma);

        // Imprime espaços em branco na terceira linha após o valor da variavel 'turma'
        for (int i = 1; i <= ((60 - turma.Length) / 2) - 1; i++)
        {
            Console.Write(" ");
        }

        // Imprime '*' no final da terceira linha e quebra para quarta linha
        Console.WriteLine("*");


        // Quarta linha

        // Imprime '*' no início da quarta linha
        Console.Write("*");

        // Imprime espaços em branco na quarta linha antes do valor da variavel 'mensagem'
        for (int i = 1; i <= ((60 - mensagem.Length) / 2) - 1; i++)
        {
            Console.Write(" ");
        }

        // Imprime na quarta linha o valor da variável 'mensagem'
        Console.Write(mensagem);

        // Imprime espaços em branco na quarta linha após o valor da variavel 'mensagem'
        for (int i = 1; i <= ((60 - mensagem.Length) / 2) - 1; i++)
        {
            Console.Write(" ");
        }

        // Imprime '*' no final da quarta linha e quebra para quinta linha
        Console.WriteLine("*");

        // Imprime a ultima linha do cabeçalho
        for (int i = 1; i <= 60; i++)
        {
            Console.Write("*");
        }

        // Quebra duas linhas
        Console.WriteLine();
        Console.WriteLine();
    }
}