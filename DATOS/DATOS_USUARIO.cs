/*      -- TRABAJO FINAL EN GRUPO: -- 
 *  Santos Ismael Pinzón García (0900-19-4909) 
 *  Samuel Rodas Aroche (0900-19-6150) 
 */
using System;
using System.Collections.Generic;
using System.Text;
using PROYECTO_FINAL.ARBOLES;
namespace PROYECTO_FINAL.DATOS
{
    public class DATOS_USUARIO : COMPARADOR
    {
        public string ID_USUARIO { get; set; }
        public string NOMBRE_USUARIO { get; set; }
        public string IMAGEN_PERFIL { get; set; }
        public DateTime Cumpleanos { get; set; }


        public DATOS_USUARIO() {

        }
        public DATOS_USUARIO(string id,string imagen_perfil, DateTime cumpleanos, string nombre_usuario)
        {
            this.ID_USUARIO = id;
            this.NOMBRE_USUARIO = nombre_usuario;
            this.IMAGEN_PERFIL = imagen_perfil;
            this.Cumpleanos = cumpleanos;
            
        }
        bool COMPARADOR.IGUALQUE(object q) {
            DATOS_USUARIO UsuarioAuxiliar = (DATOS_USUARIO)q;
            if (NOMBRE_USUARIO == UsuarioAuxiliar.NOMBRE_USUARIO)
            {
                return true;
            }
            return false;
        }

        bool COMPARADOR.MENORQUE(object q) {
            DATOS_USUARIO UsuarioAuxiliar = (DATOS_USUARIO)q;
            if (NOMBRE_USUARIO.CompareTo(UsuarioAuxiliar.NOMBRE_USUARIO) < 0)
            {
                return true;
            }
            return false;
        }
        bool COMPARADOR.MAYORQUE(object q)
        {
            DATOS_USUARIO UsuarioAuxiliar = (DATOS_USUARIO)q;
            if (NOMBRE_USUARIO.CompareTo(UsuarioAuxiliar.NOMBRE_USUARIO) > 0)
            {
                return true;
            }
            return false;
        }
        bool COMPARADOR.MENORIGUALQUE(object q) {
            DATOS_USUARIO UsuarioAuxiliar = (DATOS_USUARIO)q;
            if (NOMBRE_USUARIO.CompareTo(UsuarioAuxiliar.NOMBRE_USUARIO) <= 0) {
                return true;
            }
            return false;
        }

        bool COMPARADOR.MAYORIGUALQUE(object q) {
            DATOS_USUARIO UsuarioAuxiliar = (DATOS_USUARIO)q;
            if (NOMBRE_USUARIO.CompareTo(UsuarioAuxiliar.NOMBRE_USUARIO) >= 0)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return ID_USUARIO+" " +NOMBRE_USUARIO+ " " + Cumpleanos.ToShortDateString()+""+IMAGEN_PERFIL+" ; ";
        }

    }
}
