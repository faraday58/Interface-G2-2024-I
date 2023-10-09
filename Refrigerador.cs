using System;

namespace Interface_G2_2024_I
{
    internal class Refrigerador:LineaBlanca,IEncender
    {
        internal Refrigerador()
        {
            Marca = "";
            Console.WriteLine("Verificando si hay alimentación");

        }

        void IEncender.Encender()
        {
            
            Console.WriteLine("{0} te da la bienvenida ", Marca);
        }




    }
}
