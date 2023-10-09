using System;


namespace gRUPO2_Interfaces__graj
{
    internal class LineaBlanca
    {

        private string marca;

        public string Marca { get => marca; 
            set =>  marca = value == "" ?  "Generica":value  ; }
    }
}
