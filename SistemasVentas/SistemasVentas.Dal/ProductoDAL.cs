using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Dal
{
    public class ProductoDal
    {
        public DataTable ListarProductosDal()
        {
            string consulta = "select * from Producto";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public DataTable ProductosDatosDal()
        {
            string consulta = "SELECT        PRODUCTO.NOMBRE, TIPOPROD.NOMBRE AS TIPO_DE_PRODUCTO, PRODUCTO.DESCRIPCION, PRODUCTO.ESTADO\r\nFROM            PRODUCTO INNER JOIN\r\n                         TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD INNER JOIN\r\n                         MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA";
            return conexion.EjecutarDataTabla(consulta, "sdgg");    
        }
    }
}
