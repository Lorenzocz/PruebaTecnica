using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnica_Entidades
{
    public class MisServicios
    {
        public MisServicios(int iD_Servicio, string descripcion, string monto)
        {
            this.ID_Servicio = iD_Servicio;
           this.Descripcion = descripcion;
            this.Monto = monto;
        }

        public int ID_Servicio { get; set; }
        public string Descripcion { get; set; }
        public string Monto { get; set; }

    }
}
