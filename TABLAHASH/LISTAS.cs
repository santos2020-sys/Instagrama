/*      -- TRABAJO FINAL EN GRUPO: -- 
 *  Santos Ismael Pinzón García (0900-19-4909) 
 *  Samuel Rodas Aroche (0900-19-6150) 
 */
using System;
using System.Collections.Generic;
using System.Text;
using PROYECTO_FINAL.DATOS;
namespace PROYECTO_FINAL.TABLAHASH
{
    public class LISTAS
    {
        public Nodo primero;

        public LISTAS() {
            primero = null;
        }
        public LISTAS InsertarCabeza(Object dato) {
            Nodo nuevo;
            nuevo = new Nodo(dato);
            nuevo.Enlace = primero;
            primero = nuevo;
            return this;
        }
        
        public Object BuscarNodo(Object dato) {
            Nodo temporal = primero;
            int posicion = 1;
            while (temporal != null)
            {
                temporal = temporal.Enlace;
                if ( !temporal.Dato.Equals(dato)) {
                    return temporal.Dato;
                }
            }
            return (temporal == null)? null: temporal.Dato;
        }
    }
}
