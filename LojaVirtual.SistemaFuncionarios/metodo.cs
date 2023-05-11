class metodo
{


    //metodo que vai Somar dois valores quando chamado

    static decimal Soma(decimal numero1, decimal numero2) // parametros do metodo
    {
        //aqui vem o codigo a ser executado
        return numero1 + numero2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero: ");
        decimal numero1 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro numero: ");
        decimal numero2 = decimal.Parse(Console.ReadLine());
        
        
        Console.WriteLine(Soma(numero1,numero2)); // forma pratica


        //somar(convert.ToDecimal(Console.WriteLine()), convert.ToDecimal(Console.WriteLine());

        decimal retorno = Soma(numero1,numero2); // forma mais comum
        Console.WriteLine(retorno);
        return;


       

    }
}