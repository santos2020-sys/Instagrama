/*      -- TRABAJO FINAL EN GRUPO: -- 
 *  Santos Ismael Pinzón García (0900-19-4909) 
 *  Samuel Rodas Aroche (0900-19-6150) 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_FINAL.ARBOLES
{
    public class NODOACCESO
    {
        protected Object Dato;
        protected NODOACCESO Izquierda,Derecha;

        public NODOACCESO(Object dato) {
            Dato = dato;
            Izquierda = null;
            Derecha = null;
        }
        public NODOACCESO(NODOACCESO rIzquiera, Object dato, NODOACCESO rDerecha) {
            this.Dato = dato;
            Izquierda = rIzquiera;
            Derecha = rDerecha;
        }
        public Object DatoNodo() {
            return Dato;
        }

        public NODOACCESO SubIzquierda() {
            return Izquierda;
        }
        public NODOACCESO SubDerecha() {
            return Derecha;
        }
        public void Nuevo(object dato) {
            Dato = dato;
        }
        public void RIzquierda(NODOACCESO dato) {
            Izquierda = dato;
        }
        public void RDerecha(NODOACCESO dato) {
            Derecha = dato;
        }
        public string Recorrer() {
            return Dato.ToString();
        }
    }
}
