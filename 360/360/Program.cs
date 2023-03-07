public static class Program
{
    static void Main()
    {
        int[] ultdia = { 20, 19, 20, 20, 20, 20, 21, 22, 22, 22, 21, 21 };
        String[] nome = { "Capricornio", "Aquario", "Peixes", "Aries", "Touro", "Gemeos", "Cancer", "Leao", "Virgem", "Libra", "Escorpiao", "Sargitario" };
        int data = 8888, i = 0, dia = 0, mes = 0;

        for (; data != 9999;)
        {
            Console.WriteLine("Digite a data DDMM ou 9999 para finalizar: ");
            data = int.Parse(Console.ReadLine());
            dia = data / 100;
            mes = (data % 100) - 1;

            try
            {
                if (dia <= ultdia[mes])
                {
                    Console.WriteLine("Signo: " + nome[mes]);
                }
                else
                {
                    Console.WriteLine("Signo: " + nome[mes + 1]);
                }
            }
            catch
            {
                break;
            }
        }
    }
}