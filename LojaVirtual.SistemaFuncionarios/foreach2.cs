class foreach2
{

    static void Main(string[] args)
    {


        //escreva um programa que crie um array de tamanho 5 e armazene nele as notas de um aluno
        //em cinco diferentes provas. o programa deve calcular a media das notas e exibir o resultado na tela.


       


        Console.WriteLine("Digite o total de numeros a serem digitados.");

        int TN = Convert.ToInt32(Console.ReadLine());

        double[] notas = new double[TN];


        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Digite a nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        double media = 0;

      

        // Percorre uma matriz e retorna os itens.
        foreach (int i in notas)
        {
            media += i;
        }
        media /= TN;

        Console.WriteLine($"A média das notas é: {media}");

       



    }
}