using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Dal
{
    public class VentaDal
    {
        public DataTable ListarVentasDal()
        {
            string consulta = "select * from Venta";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public DataTable VentaDatosDal()
        {
            string consulta = "SELECT        USUARIO.NOMBREUSER, CLIENTE.TIPOCLIENTE, CLIENTE.CODIGOCLIENTE, DETALLEVENTA.PRECIOVENTA, VENTA.TOTAL, VENTA.FECHA, VENTA.ESTADO\r\nFROM            VENTA INNER JOIN\r\n                         DETALLEVENTA ON VENTA.IDVENTA = DETALLEVENTA.IDVENTA INNER JOIN\r\n                         USUARIO ON VENTA.IDVENDEDOR = USUARIO.IDUSUARIO INNER JOIN\r\n                         CLIENTE ON VENTA.IDCLIENTE = CLIENTE.IDCLIENTE";
            return conexion.EjecutarDataTabla(consulta, "sdgg");
        }
    }
}
