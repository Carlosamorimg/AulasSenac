class CalculadoraCondicao
    //class é um container de funcionalidades
{

    static void Main(string[] args)
    {



        //Console.Write("Escolha a operação que Deseja, usando o sinal da operação:");
        //String Sinal = Console.ReadLine();
        //Decimal Resultado = 0;

        //Console.Write("Digite o 1º Numero: ");
        //Decimal numero1 = Convert.ToDecimal(Console.ReadLine());

        //Console.Write("Digite o 2º Numero: ");
        //Decimal numero2 = Convert.ToDecimal(Console.ReadLine());

        //if (Sinal == "+")
        //{
        //    Resultado = numero1 + numero2;
        //} 
        //    if (Sinal == "-")
        //        {
        //            Resultado = numero1 - numero2;
        //        }
        //        if (Sinal == "*")
        //            {
        //                Resultado = numero1 * numero2;
        //            }
        //            if(Sinal == "/")
        //                {
        //                    Resultado = numero1 / numero2;
        //                }


        //Console.WriteLine();
        //Console.WriteLine("A Operação escolhida foi: " + Sinal);
        //Console.WriteLine("O Resultado de " + numero1 + "" + Sinal + "" + numero2 + " é = " + Resultado);


        Console.WriteLine("Digite sua idade, Para saber se você pode tirar sua habilitação");
        int idade = Console.Read();
         Console.Write(idade);

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
