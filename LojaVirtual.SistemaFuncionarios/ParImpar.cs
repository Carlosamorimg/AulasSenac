class ParImpar
{

    static void Main(string[] args)
    {
        string condicao = "";


        do
        {

            Console.WriteLine("Digite um numero para descobrir se ele é Par ou Impar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero " + numero + " é PAR!!!!");
            }
            else
            {
                Console.WriteLine(" O numero " + numero + " é IMPAR!!!");
            }
            Console.WriteLine("\nDeseja continuar? ");

            condicao = Convert.ToString(Console.ReadLine());
        } while (condicao == "s");

        //Console.WriteLine("Digite um numero para descobrir se ele é Par ou Impar: ");
        //int numero = Convert.ToInt32(Console.ReadLine());

        //if (numero % 2 == 0)
        //{
        //    Console.WriteLine("O numero " + numero + " é PAR!!!!");
        //}
        //else
        //{
        //    Console.WriteLine(" O numero " + numero + " é IMPAR!!!");
        //}
        Console.ReadKey();
    }
}
