using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Dal
{
    public class IngresoDal
    {
        public DataTable IngresoListarDal() 
        {
            string consulta = "SELECT        INGRESO.IDINGRESO, INGRESO.TOTAL, PROVEEDOR.NOMBRE"+
                              "FROM            INGRESO INNER JOIN"+
                         "PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";

            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
