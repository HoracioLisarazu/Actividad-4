using SistemasVentas.DAL;
using SistemaVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Dal
{
    public class PedidoDal
    {
        public DataTable ListarPedidoDal()
        {
            string consulta = "select * from pedidos";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarPedidoDal(Pedido pedido)
        {
            string consulta = "insert into pedidos values('" + pedido.Total + "'," +
                                                         "'" + pedido.Fecha + "'," +



                                                         "'Activo')";
            conexion.Ejecutar(consulta);

        }
        public Pedido ObtenerPedidoId(int id)
        {
            string consulta = "select * from pedidos where idpedido=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Pedido pedido = new Pedido();
            if (tabla.Rows.Count > 0)
            {

                pedido.IdPedido = Convert.ToInt32(tabla.Rows[0]["idpedido"]);
                pedido.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
                pedido.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                pedido.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return pedido;

        }
        public void EditarPedidoDal(Pedido pedido)
        {
            string consulta = "update pedidos set total='" + pedido.Total + "'," +

                                                "fecha='" + pedido.Fecha + "' " +


                               "where idpedido=" + pedido.IdPedido;

            conexion.Ejecutar(consulta);
        }

        public void EliminarPedidoDal(int id)
        {
            string consulta = "delete from pedidos where idpedido=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
