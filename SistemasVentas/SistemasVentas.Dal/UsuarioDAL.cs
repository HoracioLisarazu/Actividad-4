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
    public class UsuarioDal
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = "select * from usuario";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "INSERT INTO USUARIO VALUES (" + usuario.IdPersona + " , " +
                                                            " '" + usuario.NombreUser + "' , " +
                                                            " '" + usuario.Contraseña + "' , " +
                                                            " '" + usuario.FechaReg + "')";
            conexion.Ejecutar(consulta);
        }

        public DataTable UsuarioDatosDal()
        {
            string consulta = "SELECT        PERSONA.NOMBRE, PERSONA.APELLIDO, USUARIO.NOMBREUSER, ROL.NOMBRE AS CARGO, USUARIOROL.FECHAASIGNA\r\nFROM            PERSONA INNER JOIN\r\n                         USUARIO ON PERSONA.IDPERSONA = USUARIO.IDPERSONA INNER JOIN\r\n                         USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO INNER JOIN\r\n                         ROL ON USUARIOROL.IDROL = ROL.IDROL";
            return conexion.EjecutarDataTabla(consulta, "sdgg");
        }
    }
}
