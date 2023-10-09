using System;


namespace gRUPO2_Interfaces__graj
{
    internal class Estufa:LineaBlanca,IEcender
    {
        internal Estufa()
        {
            Marca = "LG";

        }

        public void Encender()
        {
            Console.WriteLine("{0} , Hola :)", Marca);
        }

    }
}
