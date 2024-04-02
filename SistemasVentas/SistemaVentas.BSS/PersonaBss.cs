using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.Modelo;

namespace SistemaVentas.BSS
{
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListarPersonaBss()
        {
            return dal.ListarPersonasDal();
        }

        public void InsertarPersonaBss(Persona persona)
        {
            dal.InsertarPersonalDal(persona);   
        }
        public Persona ObtenerIdBss(int id) 
        {
            return dal.ObtenerPersonaId(id);
        }
        public void EditarPersonaBss(Persona persona)
        {
            dal.EditarPersonaDal(persona);
        }
        public void EliminarPersonaBss(int id) 
        { 
            dal.EliminarPersonaDal(id);   
        }
    }
}
