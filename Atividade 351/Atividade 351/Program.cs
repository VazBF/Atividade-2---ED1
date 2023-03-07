public static class Program
{
    static void Main()
    {
        int i = 0;
        int OP = 0;
        string[] nome = new string[5];

        for(; i < 5; i++)
        {
            Console.WriteLine("\n\n\n\nDigite o nome da pessoa");
            nome[i] = Console.ReadLine();
        }

        Console.WriteLine("\n\n\n\n\nInforme o numero da pessoa: ");
        OP = Int32.Parse(Console.ReadLine());
        switch (OP)
        {
            case 1:
                Console.WriteLine(nome[0]);
                break;

            case 2:
                Console.WriteLine(nome[1]);
                break;
            
            case 3:
                Console.WriteLine(nome[2]);
                break;

            case 4:
                Console.WriteLine(nome[3]);
                break;

            case 5:
                Console.WriteLine(nome[4]);
                break;

            default:
                Console.WriteLine("Digite um numero de 1 a 5");
                    break;
        }
    }

}