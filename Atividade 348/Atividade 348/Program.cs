
public static class Program
{
    static void Main()
    {
        int i = 0;
        string?[] nome = new string?[5];
        float[] nota1 = new float[5];
        float[] nota2 = new float[5];
        float[] media = new float[5];



        for (; i < 5; i++)
        {
            Console.WriteLine("\n\n\nDigite o nome do aluno " + i + ": ");
            nome[i] = Console.ReadLine();

            Console.WriteLine("\n\nDigite a nota 1 do aluno " + i + ": ");
            nota1[i] = float.Parse(Console.ReadLine());

            Console.WriteLine("\n\nDigite a nota 2 do aluno " + i + ": ");
            nota2[i] = float.Parse(Console.ReadLine());

            media[i] = (nota1[i] + nota2[i]) / 2;

        }

        for(i = 0; i< 5; i++)
        {
            Console.WriteLine("\n\n\nNome e notas: \nNOME: " + nome[i] + "\nNOTA 1: " + nota1[i] + "\nNOTA 2: " + nota2[i] + "\nNOTA MEDIA: " + media[i]); 
        }
    }
}

