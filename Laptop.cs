using System;


namespace gRUPO2_Interfaces__graj
{
    internal class Laptop : LineaBlanca, IEcender, IApagar
    {
        internal Laptop()
        {
            Marca = "HP PAVILON";
        }

        public void Encender()
        {
            Console.WriteLine(" {0} le da la bienvenida ", Marca);
        }

        public void Apagar()
        {
            Console.WriteLine(" Apagando equipo ", Marca);
        }

    }
}
