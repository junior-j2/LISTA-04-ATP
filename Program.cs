/*QUESTÃO-10- Faça uma função que recebe a média final de um aluno por parãmetro e retorna o seu
conceito, conforme a tabela abaixo:
Nota Conceito
de 0,0 a 4,9 D
de 5,0 a 6,9 C
de 7,0 a 8,9 B
de 9,0 a 10,0 A*/

class questao10
{
    static void Main()
    {
        rodar(); //chama o método rodar
    }
    static void rodar() //método que executa o programa
    {
        Console.Write("Digite a média final do aluno: ");
        double media = Convert.ToDouble(Console.ReadLine());
        if (media < 0 || media > 10) //verifica se a média é válida
        {
            Console.WriteLine("Nota final inválida!");
        }
        else //se a média for válida, chama o método conceito e imprime o resultado
        Console.WriteLine("a nota conceito do aluno é: {0}", conceito(media));
    }
    static char conceito(double media) //método que retorna o conceito do aluno
    {
        if (media >= 0 && media <= 4.9) //verifica em qual faixa a média se encontra e retorna o conceito correspondente
        {
            return 'D';
        }
        else if (media >= 5 && media <= 6.9) 
        {
            return 'C';
        }
        else if (media >= 7 && media <= 8.9)
        {
            return 'B';
        }
        else if (media >= 9 && media <= 10)
        {
            return 'A';
        }
        else //caso a média seja inválida, retorna um caractere vazio
        {
            Console.WriteLine("Média inválida!");
            return ' ';
        }
    }
}