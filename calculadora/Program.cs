// See https://aka.ms/new-console-template for more information
namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, media;

            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            media = (num1 + num2) / 2;

            Console.WriteLine("A média aritmética é: " + media);
            Console.ReadLine();
        }
    }
}

