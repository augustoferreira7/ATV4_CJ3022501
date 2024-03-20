namespace ATV4_CJ3022501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, n2, operacao;
            Console.WriteLine("Digite um número:");
            n = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("escolha uma das opções abaixo");
            Console.WriteLine("1 = adição\n2 = subtração\n3 = multiplicação\n4 = divisão");
            operacao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (operacao)
            {
                case 1:
                    Console.WriteLine(n + n2);
                    break;

                case 2:
                    Console.WriteLine(n - n2);
                    break;
                case 3:
                    Console.WriteLine(n * n2);
                    break;
                case 4:
                    Console.WriteLine(n / n2);
                    break;

                default:
                    Console.WriteLine("opção inválida");
                    break;
            }
        }
    }


}
