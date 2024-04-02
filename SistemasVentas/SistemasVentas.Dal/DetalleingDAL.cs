using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Dal
{
    public class DetalleIngDal
    {
        public DataTable ListarDetallesIngDal()
        {
            string consulta = "select * from DetalleIng";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
