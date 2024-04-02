using SistemasVentas.Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.BSS
{
    public class DetalleVentaBss
    {
        DetalleVentaDal dal = new DetalleVentaDal();
        public DataTable ListarDetalleVentaBss()
        {
            return dal.ListarDetalleVentasDal();
        }
    }
}
