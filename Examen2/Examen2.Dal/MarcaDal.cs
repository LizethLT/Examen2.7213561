using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Dal
{
    public class MarcaDal
    {
        public DataTable MarcaListarDal()
        {
            string consulta = "SELECT        IDMARCA, NOMBRE"+
                                "FROM            MARCA";

            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
