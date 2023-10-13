using System;


namespace gRUPO2_Interfaces__graj
{
    internal class Smartphone : LineaBlanca, IEcender, IApagar
    {
        internal Smartphone()
        {
            Marca = "IPhone";
        }

        public void Encender()
        {
            Console.WriteLine(" Diga hola a la experiencia {0} ", Marca);
        }

        public void Apagar()
        {
            Console.WriteLine(" Su smartphone se ha apagado ", Marca);
        }

    }
}
