/*      -- TRABAJO FINAL EN GRUPO: -- 
 *  Santos Ismael Pinzón García (0900-19-4909) 
 *  Samuel Rodas Aroche (0900-19-6150) 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_FINAL.TABLAHASH
{
    public class Nodo
    {
        public Object Dato;
        public Nodo Enlace;
        public Nodo(Object dato) {
            Dato = dato;
            Enlace = null;
        }
    }
}
