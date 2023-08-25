using relacionamentoCSharp;

public class Program
{
    public static void Main(string[] args)
    {
        Motor motor1 = new Motor(1.0f);
        Carro carro1 = new Carro("Ford Ka", motor1);
        Console.WriteLine(carro1);

        Console.WriteLine("\n=========================\n");

        Motor motor2 = new Motor(1.4f);
        Carro carro2 = new Carro("Fiat Argo", motor2);
        Console.WriteLine(carro2);

        Console.WriteLine("\n=========================\n");

        Motor motor3 = new Motor(2.0f);
        Carro carro3 = new Carro("Ford Focus", motor3);
        Console.WriteLine(carro3);

        Console.WriteLine("\n=========================\n");

        Motor motor4 = new Motor(3.5f);
        Carro carro4 = new Carro("Dodge Ram", motor4);
        Console.WriteLine(carro4);

        Console.ReadKey();
    }
}
