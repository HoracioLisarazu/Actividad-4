using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Dal
{
    public class ClienteDal
    {
        public DataTable ListarClientesDal()
        {
            string consulta = "select * from Cliente";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public DataTable ClienteDatosDal()
        {
            string consulta = "SELECT        PERSONA.NOMBRE, PERSONA.APELLIDO, CLIENTE.TIPOCLIENTE, CLIENTE.CODIGOCLIENTE, VENTA.TOTAL, CLIENTE.ESTADO\r\nFROM            CLIENTE INNER JOIN\r\n                         PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA INNER JOIN\r\n                         VENTA ON CLIENTE.IDCLIENTE = VENTA.IDCLIENTE";
            return conexion.EjecutarDataTabla(consulta, "sdgg");
        }
    }
}
