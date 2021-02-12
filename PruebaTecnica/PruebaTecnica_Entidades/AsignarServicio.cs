using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnica_Entidades
{
    public class AsignarServicio
    {
        public AsignarServicio(int id,int ids)
        {
            this.ID_Vehiculo = id;
            this.ID_Servicio = ids;
        }

        public int ID_Vehiculo { get; set; }
        public int ID_Servicio { get; set; }
    }
}
