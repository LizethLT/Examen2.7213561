using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Dal
{
    public class ProductoDal
    {
        public DataTable ProductoListarVista()
        {
            string consulta = "SELECT        PRODUCTO.IDPRODUCTO, PRODUCTO.NOMBRE, PRODUCTO.UNIDAD, TIPOPROD.NOMBRE AS Expr1, PRODUCTO.DESCRIPCION"+
                               "FROM            PRODUCTO INNER JOIN"+
                        " TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD";

            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
