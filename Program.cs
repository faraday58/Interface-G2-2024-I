using System;

namespace Interface_G2_2024_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Refrigerador miRefrigerador = new Refrigerador();
            IEncender encender = miRefrigerador;
            encender.Encender();

            Estufa miEstufa = new Estufa();
            miEstufa.Encender();

            Console.ReadLine();

        }
    }
}
