using Examen2.Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Bss
{
    public class ProductoFecBss
    {
        ProductoFecDal dal = new ProductoFecDal();
        public DataTable ProductoDatosBss()
        {
            return dal.ProductoDatosDal();
        }
    }
}
