using System;


namespace gRUPO2_Interfaces__graj
{
    internal class Refigerador:LineaBlanca,IEcender
    {
        internal Refigerador()
        {
            Marca = "";
            Console.WriteLine("Verificando si hay alimentación");
        }
        
        void IEcender.Encender()
        {
            Console.WriteLine("{0} te da la bienvenida ", Marca);

        }

    }
}
