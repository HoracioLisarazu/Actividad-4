using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Dal
{
    public class IngresoDal
    {
        public DataTable ListarIngresosDal()
        {
            string consulta = "select * from Ingreso";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public DataTable IngresoDatosDal()
        {
            string consulta = "SELECT        PROVEEDOR.NOMBRE, PROVEEDOR.TELEFONO, PROVEEDOR.DIRECCION, INGRESO.FECHAINGRESO, DETALLEING.PRECIOCOSTO, DETALLEING.PRECIOVENTA, DETALLEING.CANTIDAD\r\nFROM            INGRESO INNER JOIN\r\n                         PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR INNER JOIN\r\n                         DETALLEING ON INGRESO.IDINGRESO = DETALLEING.IDINGRESO";
            return conexion.EjecutarDataTabla(consulta, "sdgg");
        }
    }
}
