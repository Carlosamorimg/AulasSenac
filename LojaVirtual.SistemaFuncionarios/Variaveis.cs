class Variaveis
{

    static void Main(string[] args)
    {
        // inteiro
        //int numero1 = 10;
        //int numero2 = 20;
        //int soma = numero1 + numero2;


        // String
        //String numero1 = "10";
        //String numero2 = "20";
        //String soma = numero1 + numero2;


        //// usando dados do usuario   usando a função ReadLine mas ela so funciona com string, use a conversão convert.Tovariavel
        //Console.Write("Digite o 1º Numero: ");
        //int numero1 = Convert.ToInt16(Console.ReadLine());
        //Console.WriteLine();
        //Console.WriteLine("Digite o 2º Numero");
        //int numero2 = Convert.ToInt16(Console.ReadLine());
        //int soma = numero1 + numero2;
        //Console.WriteLine("A Soma de "+numero1+ " + "+numero2+" é: " + soma);

        // usando dados do usuario   usando a função ReadLine mas ela so funciona com string, use a conversão convert.Tovariavel
        Console.Write("Digite o 1º Numero: ");
        Decimal numero1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine();
      
        
        Console.Write("Digite o 2º Numero: ");
        Decimal numero2 = Convert.ToDecimal(Console.ReadLine());
      
        Decimal soma = numero1 + numero2;
        
        
        Console.WriteLine();
        Console.Write("A Soma de " + numero1 + " + " + numero2 + " é: " + soma);


        //Console.WriteLine("A soma é: ");
        //Console.WriteLine(soma);

        Console.ReadKey();
    }
}
