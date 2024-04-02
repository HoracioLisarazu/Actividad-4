using SistemasVentas.Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.BSS
{
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClientesDal();
        }

        public DataTable ClienteDatosBss()
        {
            return dal.ClienteDatosDal();
        }
    }
}
