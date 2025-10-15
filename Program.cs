/*QUESTÃO-06-Escreva um procedimento que receba como parâmetro o valor do salário e o índice de
reajuste e calcule o salário atualizado. O método principal deve ler os dados, enviar para o
procedimento e escrever o novo salário.*/

class questao6
{
    static void Main()
    {
        double s, r, ns;
        Console.WriteLine("Digite o salário atual: "); 
        s = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o índice de reajuste: ");
        r = double.Parse(Console.ReadLine());
        ns = salarioatualizado(s, r);  //chamada do método
        Console.WriteLine("O novo salário é: " + ns);
    }
    static double salarioatualizado(double s, double r) //método que calcula o novo salário
    {
        double ns;
        ns = s + (s * r / 100); //cálculo do novo salário
        return ns; //retorna o novo salário para o método principal
    }
}