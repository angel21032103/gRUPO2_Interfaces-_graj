using System;


namespace gRUPO2_Interfaces__graj
{
        internal class Plancha : LineaBlanca, IEcender, IApagar
        {
            internal Plancha()
            {
                Marca = "Panasonic";
            }

            public void Encender()
            {
                Console.WriteLine(" Su plancha {0} le da la bienvenida ", Marca);
            }

            public void Apagar()
            {
                Console.WriteLine(" Adiós ", Marca);
            }
        }
    
}
