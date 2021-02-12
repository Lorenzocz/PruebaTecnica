using PruebaTecnica_AccesoDatos.SQL;
using PruebaTecnica_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnica_LogicaNegocio
{
   public class LogicaNegocio
    {

        DataSql _dataSql;

        public LogicaNegocio()
        {
            _dataSql = new DataSql();
        }


        public IEnumerable<VehiculoDTO> getAllVehiculos()
        {
            return _dataSql.getAllVehiculos();
        }

        public IEnumerable<VehiculoDTO> getListaVheiculoByServicio(int idServicio)
        {
            return _dataSql.getListaVheiculoByServicio(idServicio);
        }


        public void saveVehicule(VehiculoDTO datos)
        {
            Resgistrar resgistrar = new  Resgistrar(
                datos.Placa,datos.Dueno,datos.Marca
                );

            _dataSql.saveVehiculo(resgistrar);
        }


        public IEnumerable<VehiculoDTO> getVehiculosSinServicio()
        {
            return _dataSql.getVehiculosSinServicios();
        }

        /*Asignar Servicios*/
        public void AsignarServicio(int idV,int idS)
        {
            _dataSql.AsignarServicios(idV, idS);
        }


        /*SERVICIOS*/
        public IEnumerable<ServiciosDTO> getServices()
        {
            return _dataSql.getServices();
        }

        public void EditarServicio(MisServicios misServicios)
        {
            

            _dataSql.editarServicio(misServicios);
        }
    }
}
