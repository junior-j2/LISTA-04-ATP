/*QUESTÃO-09-Faça um procedimento que recebe, por parâmetro, a hora de início e a hora de término de
um jogo, ambas subdivididas em 2 valores distintos: horas e minutos. O procedimento deve
retornar, também por parâmetro (ref), a duração do jogo em horas e minutos, considerando
que o tempo máximo de duração de um jogo é de 24 horas e que o jogo pode começar em
um dia e terminar no outro.*/

class questao9
{
    static void Main()
    {
        int horaInicio, minutoInicio, horaTermino, minutoTermino;
        int duracaoHoras = 0, duracaoMinutos = 0; // Variáveis para armazenar a duração do jogo
        Console.WriteLine("Digite a hora de início do jogo (0-23):");
        horaInicio = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite os minutos de início do jogo (0-59):");
        minutoInicio = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a hora de término do jogo (0-23):");
        horaTermino = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite os minutos de término do jogo (0-59):");
        minutoTermino = int.Parse(Console.ReadLine());
        CalcularDuracaoJogo(horaInicio, minutoInicio, horaTermino, minutoTermino, ref duracaoHoras, ref duracaoMinutos); // Chama o procedimento para calcular a duração do jogo
        Console.WriteLine("A duração do jogo foi de {0} horas e {1} minutos.",duracaoHoras,duracaoMinutos);
    }
    static void CalcularDuracaoJogo(int horaInicio, int minutoInicio, int horaTermino, int minutoTermino, ref int duracaoHoras, ref int duracaoMinutos) // Procedimento para calcular a duração do jogo
    {
        if (minutoTermino < minutoInicio) // Ajusta os minutos se necessário
        {
            minutoTermino += 60;
            horaTermino--;
        }

        if (horaTermino < horaInicio) // Ajusta as horas se necessário
        {
            horaTermino += 24;
        }

        duracaoHoras = horaTermino - horaInicio; 
        duracaoMinutos = minutoTermino - minutoInicio; 
    }
}
