class LacoRepeticaoFor
{

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o numero de repetições: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= num; i++)
        {
            Console.WriteLine("Estou no " + i);
        }
        Console.WriteLine("\n");
        for (int i = num; i >= 0 ; i--)
        {
            Console.WriteLine("Agora estou no " + i);
        }

        Console.ReadKey();
    }
}