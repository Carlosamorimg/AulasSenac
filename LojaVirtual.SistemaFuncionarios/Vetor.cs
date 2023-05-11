class Vetor
{

    static void Main(string[] args)
    {


        //escreva um programa que crie um array de tamanho 5 e armazene nele as notas de um aluno
        //em cinco diferentes provas. o programa deve calcular a media das notas e exibir o resultado na tela.


        //double[] notas = new double[5];


        //for (int i = 0; i < notas.Length; i++)
        //{
        //    Console.Write($"Digite a nota {i + 1}: ");
        //    notas[i] = double.Parse(Console.ReadLine());
        //}


        //double media = 0;


        //for (int i = 0; i < notas.Length; i++)
        //{
        //    media += notas[i];
        //}
        //media /= notas.Length;




        ////Console.WriteLine($"A média das notas é: {media}");


        Console.WriteLine("Digite o total de numeros a serem digitados.");

        int TN = Convert.ToInt32(Console.ReadLine());

        double[] notas = new double[TN];


        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Digite a nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }
        
        double media = 0;


        for (int i = 0; i < notas.Length; i++)
        {
            media += notas[i];
        }
        media /= notas.Length;



        Console.WriteLine($"A média das notas é: {media}");

        //int linha, coluna;
        //int[,] matriz;


        //Console.WriteLine("Digite o numero de linhas: ");
        //linha = Convert.ToInt32(Console.ReadLine());


        //Console.WriteLine("Digite o numero de colunas: ");
        //coluna = Convert.ToInt32(Console.ReadLine());


        //matriz = new int[linha, coluna];

        //for (int i = 0; i < linha; i++)
        //{
        //    for (int j = 0; j < coluna; j++)
        //    {
        //        Console.WriteLine($"Digite os valores de ({i}, {j})");
        //        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        //Console.WriteLine("Matriz digitada pelo Usuario: ");

        //for (int i = 0; i < linha; i++)
        //{
        //    for (int j = 0; j < coluna; j++)
        //    {
        //        Console.WriteLine(matriz[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}


        //int linhas, colunas;
        //int[,] matriz;
        //string entrada;

        //Console.WriteLine("Digite o número de linhas:");
        //entrada = Console.ReadLine();
        //linhas = int.Parse(entrada);

        //Console.WriteLine("Digite o número de colunas:");
        //entrada = Console.ReadLine();
        //colunas = int.Parse(entrada);

        //matriz = new int[linhas, colunas];

        //for (int i = 0; i < linhas; i++)
        //{
        //    for (int j = 0; j < colunas; j++)
        //    {
        //        Console.WriteLine($"Digite o valor para a posição [{i}, {j}]:");
        //        entrada = Console.ReadLine();
        //        matriz[i, j] = int.Parse(entrada);
        //    }
        //}

        //Console.WriteLine("Matriz inserida pelo usuário:");

        //for (int i = 0; i < linhas; i++)
        //{
        //    for (int j = 0; j < colunas; j++)
        //    {
        //        Console.Write(matriz[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}



    }
}