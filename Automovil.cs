using System;


namespace gRUPO2_Interfaces__graj
{
    internal class Automóvil : LineaBlanca, IEcender, IApagar
    {
        internal Automóvil()
        {
            Marca = "Toyota";
        }

        public void Encender()
        {
            Console.WriteLine(" {0}, innovación para todos ", Marca);
        }

        public void Apagar()
        {
            Console.WriteLine(" Vehículo apagado ", Marca);
        }

    }
}
