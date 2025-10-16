/*QUESTÃO-07-Faça uma função que lê um número indeterminado de notas de alunos, calcula e retorna a
média das notas dos alunos aprovados (nota maior ou igual a 6). Faça um programa que lê
o número de alunos e imprime a média retornada pela função.*/

class questao7
{
    static void Main()
    {
        rodar(); //chama o método rodar
    }
    static void rodar()
    {
        double nota, a = 0,nt=0;
        char resp;
        do
        {
            Console.WriteLine("Qual sua nota ?");
            nota = double.Parse(Console.ReadLine());
            if (nota >= 6) //verifica se o aluno foi aprovado
            {
                a++; //conta o número de alunos aprovados
                nt += nota; //soma as notas dos alunos aprovados
            }
            Console.WriteLine("Deseja continuar ? (s/n)"); //condição de parada
            resp = char.Parse(Console.ReadLine());
        } while (resp == 's' || resp == 'S'); 
        Console.WriteLine("A média de notas de alunos aprovados é: " + Media(nt, a)); //chama o método média
    }
    static double Media(double nt, double a) //método que calcula a média
    {
        if (a == 0) //verifica se houve alunos aprovados
        {
            Console.WriteLine("Nenhum aluno foi aprovado.");
            return 0;
        }
        else //calcula a média
        {
            double media;
            media = nt / a;
            return media;
        }
    }
}