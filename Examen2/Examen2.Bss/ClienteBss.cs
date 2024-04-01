using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2.Dal;


namespace Examen2.Bss
{
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ClienteListarBss()
        {
            return dal.ClienteListarDal();
        }
    }
}
