class LacoRepeticao
{

    static void Main(string[] args)
    {
      

        int contador = 0;
        while (contador <= 9)
        {
            Console.WriteLine("Você está no " + contador);
            contador = contador + 1;
            
        }
        while (contador >= 0)
        {
            Console.WriteLine("Você esta no " + contador);
            contador--;
        }

        

        Console.ReadKey();
    }
}
