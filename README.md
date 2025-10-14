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
======================================================================================================================================================

