using SistemasVentas.Dal;
using SistemasVentas.DAL;
using SistemaVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.BSS
{
    public class PedidoBss
    {
        PedidoDal dal = new PedidoDal();
        public DataTable ListarPedidoBss()
        {
            return dal.ListarPedidoDal();
        }

        public void InsertarPedidoBss(Pedido pedido)
        {
            dal.InsertarPedidoDal(pedido);
        }
        public Pedido ObtenerIdBss(int id)
        {
            return dal.ObtenerPedidoId(id);
        }
        public void EditarPedidoBss(Pedido pedido)
        {
            dal.EditarPedidoDal(pedido);
        }
        public void EliminarPedidoBss(int id)
        {
            dal.EliminarPedidoDal(id);
        }
    }
}
