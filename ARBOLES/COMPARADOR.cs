/*      -- TRABAJO FINAL EN GRUPO: -- 
 *  Santos Ismael Pinzón García (0900-19-4909) 
 *  Samuel Rodas Aroche (0900-19-6150) 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_FINAL.ARBOLES
{
    interface COMPARADOR{
        bool IGUALQUE(object q);
        bool MENORQUE(object q);
        bool MENORIGUALQUE(object q);
        bool MAYORQUE(object q);
        bool MAYORIGUALQUE(object q);
    }
}
