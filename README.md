**QUESTÃO-01**

```csharp
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
```

**QUESTÃO-02**

```csharp
/*QUESTÃO-02-A prefeitura de uma cidade fez uma pesquisa entre os seus habitantes, coletando dados
sobre o salário e número de filhos. Faça um procedimento que leia esses dados para um
número não determinado de pessoas, calcule e exiba a média de salário da população (a
condição de parada pode ser um flag ou a quantidade N). Faça um programa que acione o
procedimento.*/

public class questao2
{
    public static void Main() 
    {
        roda(); //chama o procedimento
    }

static void roda() 
{
        double s = 0, nf, ms, st = 0, x = 0;
        string p;
        do //laço de repetição
        {

            Console.WriteLine("digite seu salário:");
            s = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o número de filhos:");
            nf = double.Parse(Console.ReadLine());
            x++; //acumula o número de habitantes na variável x
            st += s; //acumula o salário na variável st
            Console.WriteLine("deseja continuar? (s/n)");
            p = Console.ReadLine(); 
        } while (p == "s"); //condição de parada
            ms = st / x; //calcula a média de salário
            Console.WriteLine("a média de salário da população é: " + ms);
}
}
```

**QUESTÃO-03**

```csharp

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

```

**QUESTÃO-04**

```csharp

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

```

**QUESTÃO-05**

```csharp

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

```

**QUESTÃO-06**

```csharp

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

```

**QUESTÃO7**

```csharp

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
```