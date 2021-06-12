/*      -- TRABAJO FINAL EN GRUPO: -- 
 *  Santos Ismael Pinzón García (0900-19-4909) 
 *  Samuel Rodas Aroche (0900-19-6150) 
 */
using System;
using System.Collections.Generic;
using System.Text;
using PROYECTO_FINAL.DATOS;
namespace PROYECTO_FINAL.ARBOLES
{
    public class NODOARBOLAVL : NODOACCESO
    {
        public int FactorE;
        public NODOARBOLAVL(Object dato) : base(dato) {
            FactorE = 0;
        }
        public NODOARBOLAVL(Object dato, NODOARBOLAVL rizquierda, NODOARBOLAVL rderecha) : base(rizquierda, dato, rderecha) {

            FactorE = 0;
        }
    } 
}
