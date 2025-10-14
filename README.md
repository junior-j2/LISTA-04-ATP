**QUESTÃO-01**
´´´csharp
/*QUESTÃO-01-A potenciação é uma operação matemática que representa o processo de multiplicar um
número por ele mesmo várias vezes, usando um expoente ou índice. Ela é frequentemente
expressa como "a elevado à potência de n" e é escrita na forma a^n, onde "a" é a base e "n"
é o expoente. O resultado da operação é chamado de potência. Diante disso, escreva uma
função que receba dois números: base e expoente e calcule a base elevada ao expoente.
Não utilize a função Math.Pow.*/

class Questão1
{
    public static void roda()//função que roda o programa
    {
        Console.WriteLine("Digite a base: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o expoente: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("O resultado de " + a + " elevado a " + n + " é: " + Potencia(a, n));
    }
    static int Potencia(int a, int n) //função que calcula a potência
    {
        int m = 1;
        for (int x = 0; x < n; x++)
            m = m * a;
        return m;
    }
    public static void Main() //função principal
    {
        roda();
    }
}
´´´
**QUESTÃO-02**
´´´csharp
/*QUESTÃO-02-A prefeitura de uma cidade fez uma pesquisa entre os seus habitantes, coletando dados
sobre o salário e número de filhos. Faça um procedimento que leia esses dados para um
número não determinado de pessoas, calcule e exiba a média de salário da população (a
condição de parada pode ser um flag ou a quantidade N). Faça um programa que acione o
procedimento.*/

public class questao2
{
    public static void Main()
    {
        roda();
    }

static void roda()
{
    double s, nf, ms, st=0 , x=0;
    do
    {
        Console.WriteLine("digite seu salário (ou negativo para sair):");
        s = double.Parse(Console.ReadLine());
        Console.WriteLine("digite o número de filhos:");
        nf = double.Parse(Console.ReadLine());
            x++;
            st += s;
    } while (s >= 0);
        ms = st / x;
        Console.WriteLine("a média de salário da população é: " + ms);
}
}
´´´
