using System;


namespace gRUPO2_Interfaces__graj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plancha miPlancha = new Plancha();
            miPlancha.Encender();
            miPlancha.Apagar();

            Televisor miTelevisor = new Televisor();
            miTelevisor.Encender();
            miTelevisor.Apagar();

            Smartphone miSmartphone = new Smartphone();
            miSmartphone.Encender();
            miSmartphone.Apagar();

            Automóvil miAutomóvil = new Automóvil();
            miAutomóvil.Encender();
            miAutomóvil.Apagar();

            Laptop miLaptop = new Laptop();
            miLaptop.Encender();
            miLaptop.Apagar();

            Console.ReadLine();

        }
    }
}
