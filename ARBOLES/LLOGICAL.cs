/*      -- TRABAJO FINAL EN GRUPO: -- 
 *  Santos Ismael Pinzón García (0900-19-4909) 
 *  Samuel Rodas Aroche (0900-19-6150) 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_FINAL.ARBOLES
{
    class LLOGICAL
    {
        Boolean vlOGICA;
            
        public LLOGICAL(Boolean dato) {
            vlOGICA = dato;
        }
        public void SetL(Boolean dato) {
            vlOGICA = dato;
        }
        public Boolean Dato() {
            return vlOGICA;
        }

    }
}
