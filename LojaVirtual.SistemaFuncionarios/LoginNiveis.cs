using System;


class LoginNiveis
//class é um container de funcionalidades
{

    static void Main(string[] args)
    {
        //// cadastro de login e senha 

        //Console.WriteLine("Cadatre um Login:");
        //string Login = Console.ReadLine();

        //Console.WriteLine("Cadastre uma Senha:");
        //string Senha = Console.ReadLine();

        //// entrada de dados do usuario

        //Console.WriteLine("Entre com seu Login: ");
        //string Log1 = Console.ReadLine();

        //Console.WriteLine("Entre com sua Senha: ");
        //string sen1 = Console.ReadLine();


        string Usuario1 = "@admin";
        string Usuario2 = "@finan";
        string Usuario3 = "@expe";

        Console.WriteLine("Entre com seu Nome: ");
        string nome = Console.ReadLine();
        
        Console.WriteLine("Entre com seu login: ");
        string log = Console.ReadLine();
       

        if (nome + Usuario1 == log)
        {
            Console.WriteLine("Acesso nivel Administrativo.");
        }
        else if (nome + Usuario2 == log)
        {
            Console.WriteLine("Acesso nivel Financeiro.");
        }
        else if (nome + Usuario3 == log)
        {
            Console.WriteLine("Acesso nivel Expedição.");
        }
        else
        {
            Console.WriteLine("Acesso Negado!");
        }




        Console.ReadKey();
    }
}
