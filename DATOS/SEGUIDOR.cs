/*      -- TRABAJO FINAL EN GRUPO: -- 
 *  Santos Ismael Pinzón García (0900-19-4909) 
 *  Samuel Rodas Aroche (0900-19-6150) 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_FINAL.DATOS
{
    public class SEGUIDOR
    {
        public string SEGUIDO { get; set; }
        public string SEGUIDORES { get; set; }
        public SEGUIDOR(string seguido, string seguidores) {
            this.SEGUIDO = seguido;
            this.SEGUIDORES = seguidores;
        }
    }
}
