class LoginSenha
    //class é um container de funcionalidades
{

    static void Main(string[] args)
    {

        Console.WriteLine("Cadastre seu login: ");
        string Login = Console.ReadLine();

        Console.WriteLine("Cadastre sua senha: ");
        string Senha = Console.ReadLine();

        //Console.WriteLine(Login );
        //Console.WriteLine(Senha);

        Console.WriteLine("Entre com seu login:");
        string d1 = Console.ReadLine();

        Console.WriteLine("Entre com sua senha:");
        string d2 = Console.ReadLine();

        //if(Login == d1 && Senha == d2)
        //{
        //    Console.WriteLine("Bem vindo ao sistema");
        //}
        //   else
        //    {
        //        Console.WriteLine("Senha ou Login invalidos");
        //    }

        if (Login == d1)
        {
           
        }else
        {
            Console.WriteLine("Acesso Negado!!!");
        }
        if (Senha == d2)
        {
            Console.WriteLine("acesso ao sistema!");
        }
        else
            Console.WriteLine("Acesso Negado!!!");

        Console.ReadKey();
    }
}
