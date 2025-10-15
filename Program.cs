/*QUESTÃO-05-Faça uma função que recebe um valor inteiro e verifica se o valor é positivo ou negativo.
A função deve retornar um valor lógico (true ou false). Faça um programa que lê N
números e para cada um deles exibe uma mensagem informando se ele é positivo ou não,
dependendo se foi retornado verdadeiro ou falso pela função.*/

class questao5
{
    static void Main() 
    {
        double n;
        string resp;
        do 
        {
            Console.Write("Digite um número: ");
            n = double.Parse(Console.ReadLine());
            if (positivo(n)) //chamada da função
            {
                Console.WriteLine("O número é positivo!");
            }
            else
            {
                Console.WriteLine("O número é negativo!");
            }
            Console.Write("Deseja continuar? (s/n): "); 
            resp = Console.ReadLine();
        } while (resp == "s"); //condição de parada
    }
    static bool positivo(double n) //função que verifica se o número é positivo ou negativo
    {
        if (n >= 0) //se o número for maior ou igual a zero, é positivo
        {
            return true; //retorna verdadeiro
        }
        else //se o número for menor que zero, é negativo
        {
            return false; //retorna falso
        }
    }
}