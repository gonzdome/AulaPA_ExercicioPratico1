using System;

namespace AulaPA_ExercicioPratico1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o modelo de seu veículo?");
            String modelo = Console.ReadLine();

            Console.WriteLine("Qual a marca de seu veículo?");
            String marca = Console.ReadLine();

            Console.WriteLine("Qual a cor de seu veículo?");
            String cor = Console.ReadLine();

            Console.WriteLine("Qual o ano de seu veículo?");
            String ano = Console.ReadLine();

            Console.WriteLine("Qual a quilometragem de seu veículo?");
            String km = Console.ReadLine();

            Console.Write("\n\nO modelo de seu carro é: " + modelo
                + "\n\nSua marca é: " + marca
                + "\n\nA cor de seu carro é: " + cor
                + "\n\nO ano de seu carro é: " + ano
                + "\n\nA quilometragem de seu carro é: " + km);

            Console.ReadKey();
        }
    }
}
