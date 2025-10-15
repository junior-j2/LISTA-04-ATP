/*QUESTÃO-04-Em matemática, o algoritmo de Euclides é um método simples e eficiente de encontrar o
Máximo Divisor Comum (MDC) entre dois números inteiros diferentes de zero. Crie uma
função que receba dois números e calcule o MDC.*/

class Questao4 
{
    static void Main() 
    {
        roda();
    }
    public static void roda() //função que roda o programa
    {
        Console.WriteLine("digite um número inteiro diferente de zero:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("digite outro número inteiro diferente de zero:");
        int y = int.Parse(Console.ReadLine());
        int r = mdc(x, y); //chama a função mdc e armazena o resultado em r
        Console.WriteLine($"O MDC entre {0} e {1} é {2}",x,y,r); 
    }
    static int mdc(int x, int y) //função que calcula o MDC
    {
        while (y != 0) //enquanto y for diferente de zero
        {
            int r = x % y; //r recebe o resto da divisão de x por y
            x = y; 
            y = r;
        }
        return x; //retorna o valor de x, que é o MDC
    }
}