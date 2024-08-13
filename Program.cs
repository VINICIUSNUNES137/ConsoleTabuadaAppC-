namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int minMultiplicando;
            int maxMultiplicando;
            int minMultiplicador;
            int maxMultiplicador;
            int contadorMultiplicador;
            int contadorMultiplicando;

            Console.WriteLine("Bem vindo ao Sistema de tabuada");
            Console.Write("Qual o número que será o primeiro multiplicado? (mínimo multiplicando): ");
            minMultiplicando = Int32.Parse(Console.ReadLine());

            Console.Write("Qual o número que será o último multiplicado? (máximo multiplicando): ");
            maxMultiplicando = Int32.Parse(Console.ReadLine());

            Console.Write("Qual será o começo da taboada? (mínimo multiplicador): ");
            minMultiplicador = Int32.Parse(Console.ReadLine());

            Console.Write("Qual será o final da taboada? (máximo multiplicador): ");
            maxMultiplicador = Int32.Parse(Console.ReadLine());

            contadorMultiplicador = minMultiplicador;
            contadorMultiplicando = minMultiplicando;

            while (contadorMultiplicando <= maxMultiplicando)
            {
                Console.WriteLine("|--------------------------|");
                Console.WriteLine("|       TABUADA DO {0,-2}      |", contadorMultiplicando);
                Console.WriteLine("|--------------------------|");

                while (contadorMultiplicador <= maxMultiplicador)
                {
                    int resultado = contadorMultiplicador * contadorMultiplicando;
                    Console.WriteLine("| {0,2} x {1,-2} = {2,-3}            |", contadorMultiplicando, contadorMultiplicador, resultado);
                    contadorMultiplicador++;
                }

                Console.WriteLine("|--------------------------|");
                contadorMultiplicando++;
                contadorMultiplicador = minMultiplicador; 
            }
        }
    }
}
