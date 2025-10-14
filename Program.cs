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
        double s = 0, nf, ms, st = 0, x = 0;
        string p;
        do
        {

            Console.WriteLine("digite seu salário:");
            s = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o número de filhos:");
            nf = double.Parse(Console.ReadLine());
            x++;
            st += s;
            Console.WriteLine("deseja continuar? (s/n)");
            p = Console.ReadLine();
        } while (p == "s");
            ms = st / x;
            Console.WriteLine("a média de salário da população é: " + ms);
}
}