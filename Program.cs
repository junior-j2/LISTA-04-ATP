/*QUESTÃO-03-Escreva um procedimento que receba 3 valores reais X, Y e Z e que verifique se esses
valores podem ser os comprimentos dos lados de um triângulo e, neste caso, exibe qual é o
tipo de triângulo formado. Para que X, Y e Z formem um triângulo é necessário que a
seguinte propriedade seja satisfeita: o comprimento de cada lado de um triângulo é menor
do que a soma do comprimento dos outros dois lados. O procedimento deve identificar o
tipo de triângulo formado observando as seguintes definições:
- Triângulo Equilátero: os comprimentos dos 3 lados são iguais;
- Triângulo Isósceles: os comprimentos de pelo menos 2 lados são iguais.
- Triângulo Qualquer: os comprimentos dos 3 lados são diferentes.
Faça um programa que leia um número indeterminado de triângulos (valores dos 3 lados) e
para cada triângulo, acione o procedimento.*/

public class questao3
{
    public static void Main() // ponto de entrada do programa
    {
        roda(); // chama a função roda
    }
    static void roda() // função roda
    {
        double x, y, z;
        string resposta;

        do
        {
            Console.Write("Digite o valor do lado X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do lado Y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do lado Z: ");
            z = Convert.ToDouble(Console.ReadLine());

            verificarTriangulo(x, y, z); // chama a função verificarTriangulo

            Console.Write("Deseja verificar outro triângulo? (s/n): ");
            resposta = Console.ReadLine();
        } while (resposta == "s"); // repete enquanto a resposta for "s"
    }
    static void verificarTriangulo(double x, double y, double z) // função que verifica o tipo de triângulo
    {
        if (x < y + z && y < x + z && z < x + y) // verifica se os lados formam um triângulo
        {
            if (x == y && y == z) // verifica se os lados são iguais
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (x == y || y == z || x == z) // verifica se pelo menos dois lados são iguais
            {
                Console.WriteLine("Triângulo Isósceles");
            }
        }
        if (x != y && y != z && x != z) // verifica se os lados são diferentes
        {
            Console.WriteLine("Triângulo qualquer");
        }
    }
}