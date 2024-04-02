using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Dal
{
    public class UsuarioRolDal
    {
        public DataTable ListarUsuariosRolDal()
        {
            string consulta = "select * from UsuarioRol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public DataTable UsuarioRolDatosDal()
        {
            string consulta = "SELECT        USUARIO.NOMBREUSER, ROL.NOMBRE, USUARIOROL.ESTADO, USUARIOROL.FECHAASIGNA\r\nFROM            USUARIOROL INNER JOIN\r\n                         USUARIO ON USUARIOROL.IDUSUARIO = USUARIO.IDUSUARIO INNER JOIN\r\n                         ROL ON USUARIOROL.IDROL = ROL.IDROL";
            return conexion.EjecutarDataTabla(consulta, "sdgg");
        }
    }
}
