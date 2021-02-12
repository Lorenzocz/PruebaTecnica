using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnica_Entidades
{
    public class Resgistrar
    {

        public Resgistrar(string Placa, string Dueno, string Marca)
        {
            this.Placa = Placa;
            this.Dueno = Dueno;
            this.Marca = Marca;
        }

        public int ID_Vehiculo { get; set; }
        public string Placa { get; set; }
        public string Dueno { get; set; }
        public string Marca { get; set; }
    }
}
