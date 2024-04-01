using Examen2.Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Bss
{
    public class MarcaBss
    {
        MarcaDal dal = new MarcaDal();
        public DataTable MarcaListarBss()
        {
            return dal.MarcaListarDal();
        }
    }
}
