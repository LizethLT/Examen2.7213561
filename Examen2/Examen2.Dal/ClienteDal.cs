using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Dal
{
    public class ClienteDal
    {
        public DataTable ClienteListarDal()
        {
            string consulta = "SELECT CLIENTE.IDCLIENTE, (PERSONA.NOMBRE+''+ PERSONA.APELLIDO)NOMBRECOMPLETO "+
                              " FROM CLIENTE INNER JOIN"+
                              " PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";

            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }

    }
}
