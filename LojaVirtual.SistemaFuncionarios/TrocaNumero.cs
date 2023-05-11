using System;

class TrocaNumero
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite um Numero: ");
        Decimal n1 = Convert.ToDecimal(Console.ReadLine());


        Console.WriteLine("Digite outro Numero: ");
        Decimal n2 = Convert.ToDecimal(Console.ReadLine());

        Decimal n3 = n1;
                n1 = n2;
                n2 = n3; 


        Console.WriteLine("seu primeiro numero é: " + n1);
        Console.WriteLine("seu segundo numero é: " + n2);

    }
}
