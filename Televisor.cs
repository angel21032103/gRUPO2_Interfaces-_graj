using System;


namespace gRUPO2_Interfaces__graj
{
    internal class Televisor : LineaBlanca, IEcender, IApagar
    {
        internal Televisor()
        {
            Marca = "Samsung";
        }

        public void Encender()
        {
            Console.WriteLine(" Sumérgete con {0} ", Marca);
        }

        public void Apagar()
        {
            Console.WriteLine(" Televisor apagado ", Marca);
        }

    }
}
