using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Dal
{
    public class ProveedorDal
    {
        public DataTable ProveedorListarDal()
        {
            string consulta = "" ;

            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
