using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Dal
{
    public class ProductoFecDal
    {
        public DataTable ProductoDatosDal()
        {
            string consulta = "SELECT        PRODUCTO.NOMBRE, PRODUCTO.IDPRODUCTO, PRODUCTO.DESCRIPCION, DETALLEING.FECHAVENC"+
                               "FROM            PRODUCTO INNER JOIN"+
                         "DETALLEING ON PRODUCTO.IDPRODUCTO = DETALLEING.IDPRODUCTO";

            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
