using System;


namespace gRUPO2_Interfaces__graj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Refigerador miRefigerador = new Refigerador();
            IEcender ecender = miRefigerador;
            ecender.Encender();

            Estufa miEstufa= new Estufa();
            miEstufa.Encender();

            Console.ReadLine();

        }
    }
}
