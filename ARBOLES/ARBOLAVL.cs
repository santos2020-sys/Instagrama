/*      -- TRABAJO FINAL EN GRUPO: -- 
 *  Santos Ismael Pinzón García (0900-19-4909) 
 *  Samuel Rodas Aroche (0900-19-6150) 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace PROYECTO_FINAL.ARBOLES

{
    class ARBOLAVL
    {
        private NODOARBOLAVL Raiz;
        string texto1 = "";
        string texto2 = "";
        string texto3 = "";

        public string s;
        //int x = 0;
        public ARBOLAVL()
        {
            Raiz = null;
        }
        public NODOARBOLAVL ObtnerRaiz() {
            return Raiz;
        }
        public string obteners() {
            return s;
        }
        private NODOARBOLAVL RotacionIzquierda(NODOARBOLAVL nodo1, NODOARBOLAVL nodo2) {
            nodo1.RIzquierda(nodo2.SubDerecha());
            nodo2.RDerecha(nodo1);
            if (nodo2.FactorE == -1)
            {
                nodo1.FactorE = 0;
                nodo2.FactorE = 0;
            }
            else {
                nodo1.FactorE = -1;
                nodo2.FactorE = 1;
            }
            return nodo2;
        }
        private NODOARBOLAVL RotacionDerecha(NODOARBOLAVL nodo1, NODOARBOLAVL nodo2) {
            nodo1.RDerecha(nodo2.SubIzquierda());
            nodo2.RIzquierda(nodo1);
            if (nodo2.FactorE == +1)
            {
                nodo1.FactorE = 0;
                nodo2.FactorE = 0;
            }
            else
            {
                nodo1.FactorE = +1;
                nodo2.FactorE = -1;
            }
            return nodo2;
        }
        private NODOARBOLAVL RotacionDobleIzquierda(NODOARBOLAVL nodo1, NODOARBOLAVL nodo2) {
            NODOARBOLAVL nodo3;
            nodo3 = (NODOARBOLAVL)nodo2.SubDerecha();
            nodo1.RIzquierda(nodo3.SubDerecha());
            nodo3.RDerecha(nodo1);
            nodo2.RDerecha(nodo3.SubIzquierda());
            nodo3.RIzquierda(nodo2);
            if (nodo3.FactorE == -1)

                nodo2.FactorE = +1;
            else 
                nodo2.FactorE = 0;
            if (nodo3.FactorE == -1)
                nodo1.FactorE = 1;
            else
                nodo1.FactorE = 0;
            nodo3.FactorE = 0;
            return nodo3;
        }
        private NODOARBOLAVL RotacionDobleDerecha(NODOARBOLAVL nodo1, NODOARBOLAVL nodo2)
        {
            NODOARBOLAVL nodo3;
            nodo3 = (NODOARBOLAVL)nodo2.SubIzquierda();
            nodo1.RDerecha(nodo3.SubIzquierda());
            nodo3.RIzquierda(nodo1);
            nodo2.RIzquierda(nodo3.SubDerecha());
            nodo3.RDerecha(nodo2);
            if (nodo3.FactorE == +1)
            {
                nodo1.FactorE = -1;
            }
            else
            {
                nodo1.FactorE = 0;
            }
            if (nodo3.FactorE == -1)
            {
                nodo2.FactorE = 1;
            }
            else
            {
                nodo1.FactorE = 0;
            }
            nodo3.FactorE = 0;
            return nodo3;
        }
        public NODOARBOLAVL InsertarDatoAVL(NODOARBOLAVL raiz, COMPARADOR dato, LLOGICAL d) {
            //string[] Lineas = File.ReadAllLines(@"C:\temp\bitacora.txt");
            NODOARBOLAVL nodo;
            if (raiz == null)
            {
                raiz = new NODOARBOLAVL(dato);
                d.SetL(true);
            }
            else if (dato.MENORQUE(raiz.DatoNodo()))
            {
                NODOARBOLAVL Izquierda;
                Izquierda = InsertarDatoAVL((NODOARBOLAVL)raiz.SubIzquierda(), dato, d);
                raiz.RIzquierda(Izquierda);
                if (d.Dato())
                {
                    switch (raiz.FactorE)
                    {
                        case 1:
                            
                            raiz.FactorE = 0;
                            d.SetL(false);
                            break;
                        case 0:
                            raiz.FactorE = -1;
                            break;
                        case -1:
                            nodo = (NODOARBOLAVL)raiz.SubIzquierda();
                            if (nodo.FactorE == -1)
                            {
                                raiz = RotacionIzquierda(raiz, nodo);
                            }
                            else
                            {

                                 s = "FATOR DE EQUILIBRIO = " + Raiz.FactorE + "Nodos en rotacion: " + raiz + "," + nodo + "Rotaccion DI";
                               // x = x + x;
                                    //archivo.WriteLine("FATOR DE EQUILIBRIO = " + Raiz.FactorE + "Nodos en rotacion: "+raiz+","+ nodo+"Rotaccion DI");
                                raiz = RotacionDobleIzquierda(raiz, nodo);
                                d.SetL(false);
                            }
                            break;
                    }
                }
            }
            else if (dato.MAYORQUE(raiz.DatoNodo()))
            {
                NODOARBOLAVL Dereccha;
                Dereccha = InsertarDatoAVL((NODOARBOLAVL)raiz.SubDerecha(), dato, d);
                raiz.RDerecha(Dereccha);
                if (d.Dato())
                {
                    switch (raiz.FactorE)
                    {
                        case -1:
                            raiz.FactorE = 0;
                            d.SetL(false);
                            break;
                        case 0:
                            raiz.FactorE = +1;
                            break;
                        case 1:
                            nodo = (NODOARBOLAVL)raiz.SubDerecha();
                            if (nodo.FactorE == +1)
                            {
                                raiz = RotacionDerecha(raiz, nodo);
                            }
                            else
                                raiz = RotacionDobleDerecha(raiz, nodo);
                                 s = "FATOR DE EQUILIBRIO = " + Raiz.FactorE + "Nodos en rotacion: " + raiz + "," + nodo + "Rotaccion DD";
                            d.SetL(false);
                            break;
                    }
                }
            }
            else
                Console.WriteLine("nO PUEDEN HABER DOS REGISTROS IGUALES");
                //throw new Exception("No pueden haber dos estudiantes con la misma clave");
            return raiz;
        }

        public void InsertarDato(object dato1) {
            COMPARADOR dato;
            LLOGICAL d = new LLOGICAL(false);
            dato = (COMPARADOR)dato1;
            Raiz = InsertarDatoAVL(Raiz,dato,d);
        }
       
        public static string preorden(NODOACCESO dato)
        {
            if (dato != null)
            {
                return dato.Recorrer()+preorden(dato.SubIzquierda()) + preorden(dato.SubDerecha());
            }
            return "";
        }
        public static string EnOrden(NODOACCESO dato) {
            if (dato != null) {
                return EnOrden(dato.SubIzquierda()) + dato.Recorrer() + EnOrden(dato.SubDerecha());
            }
            return "";
        }
        public static string PostOrden(NODOACCESO dato) {
            if (dato != null)
            {
                return EnOrden(dato.SubIzquierda()) + EnOrden(dato.SubDerecha()) + dato.Recorrer();
            }
            return "";
        }
        public NODOACCESO buscar(object datob) {
            COMPARADOR dato;
            dato = (COMPARADOR)datob;
            if (Raiz == null)
            {
                return null;
            }
            else
                if (buscar(Raiz, dato) == null) {
                return null;
            }
            return buscar(Raiz,dato);
        }
        public bool Autenticar(object datob) {
            if (buscar(datob) != null)
            {
                return true;
            }
            else return false;
        }
        protected NODOACCESO buscar(NODOACCESO raiz, COMPARADOR dato) {
            if (raiz == null)
                return null;
            else if (dato.IGUALQUE(raiz.DatoNodo()))
                return raiz;
            else if (dato.MENORQUE(raiz.DatoNodo()))
                return buscar(raiz.SubIzquierda(), dato);
            else
                return buscar(raiz.SubDerecha(), dato);
        }
    }
}
