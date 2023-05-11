class Acesso
{

    static void Main(string[] args)
    {
        Console.WriteLine("Cadastre seu login: ");
        String login = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Cadastre sua senha: ");
        string senha = Convert.ToString(Console.ReadLine());


        int contador = 0;
       
            Console.WriteLine("Entre com seu Login: ");
            string log = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Entre com sua Senha: ");
            string sen = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Entre com o Login");
        if (log == login)
        {
            Console.WriteLine("Entre com a senha!!!");
        }
        else
        {
            Console.WriteLine("Login errado!!!");
        } 

        Console.WriteLine("entre com a Senha!!!");
        if (sen == senha)
        {
            Console.WriteLine("Entre com a senha!!!");
        }
        else
            do
            {
                {
                    Console.WriteLine("Senha errada!!!");
                }
            } while (contador < 3);
      contador++;

       Console.ReadKey();
    }
}
