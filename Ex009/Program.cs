namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.Write("Digite o valor do ladoA:");
                ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do ladoB:");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do ladoC:");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                Console.WriteLine("Os valores informados formam um triângulo");
            }
            else 
            {
                Console.WriteLine("Os valores informados não formam um triângulo");
            }
        }
    }
}
