using System;

namespace Aula8Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {      
            CartaoDeCredito visa = new CartaoDeCredito();
            visa.limite = 2500f;

            System.Console.WriteLine("Quanto acrescentar no limite?");
            float acres =  float.Parse(Console.ReadLine() );

            visa.AumentarLimite(acres);
            System.Console.WriteLine("Novo Limite: R$ "+visa.limite);

            System.Console.WriteLine("Digite a data de pagamento:");
            visa.data = DateTime.Parse(Console.ReadLine() );

            System.Console.WriteLine("Data: " + visa.data);
        }
    }
}
