using SistemasVentas.Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.BSS
{
    public class ProductoBss
    {
        ProductoDal dal = new ProductoDal();
        public DataTable ListarProductoBss()
        {
            return dal.ListarProductosDal();
        }

        public DataTable ProductoDatosBss() 
        {
            return dal.ProductosDatosDal();
        }
    }
}
