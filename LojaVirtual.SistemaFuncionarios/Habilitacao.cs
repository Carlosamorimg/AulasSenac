class Habilitacao
    //class é um container de funcionalidades
{

    static void Main(string[] args)
    {


        Console.WriteLine("Digite sua idade, Para saber se você pode tirar sua habilitação");
        int idade = Convert.ToInt16(Console.ReadLine());
        

        

        if(idade >= 18)
        {
            Console.Write("Sua idade é: " + idade + " Parabéns, você pode tirar sua Habilitação");
        }
            if(idade < 18)
                {
                     Console.Write("Sua idade é: " + idade + " Infelizmente você ainda não tem idade para isso.");
                }



        Console.ReadKey();
    }
}
