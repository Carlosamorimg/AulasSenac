class celsius
{

    static void Main(string[] args)
    {
        

        Console.WriteLine("Digite a Temperatura em Graus Celsius: ");
        int temp =Convert.ToInt32(Console.ReadLine());

       int fare = temp * 9/ 5 + 32;

        Console.WriteLine(temp +"º Graus Celsius é equivalente a  " + fare+ "º Graus Fahrenheit");


        Console.ReadKey();
    }
}
