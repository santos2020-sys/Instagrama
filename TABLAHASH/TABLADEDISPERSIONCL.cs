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
   public class TABLADEDISPERSIONCL
    {
        public static readonly int TamañoTabla = 7;
        LISTAS[] tablah = new LISTAS[TamañoTabla];
        
        public int Dispercion(double x) {
            return Convert.ToInt16(x % TamañoTabla);
        }
        public int HashF(string clave) {
            return Dispercion(Convert.ToDouble(clave));
        }
        public void Insertar(Object dato, string Clave) {
            int dato2 = Convert.ToInt32(Clave.Length);
            //double dato3 =Convert.ToDouble( dato2);
            int Posicion = 0;
            Posicion = Dispercion(Convert.ToDouble(dato2));
            if (tablah[Posicion] == null) 
                tablah[Posicion] = new LISTAS();
            tablah[Posicion].InsertarCabeza(dato); 
        }
        public void Eliminar(string clave) {
            int Posicion = 0;
            Posicion = Dispercion(System.Convert.ToDouble(clave));
            tablah[Posicion] = null;
        }
        public object Buscar(string Clave) {
            int dato2 = Convert.ToInt32(Clave.Length);
            int Posicion = 0;
            Posicion = Dispercion(System.Convert.ToDouble(dato2));
            return tablah[Posicion].BuscarNodo(Clave);
        }
    }
}
