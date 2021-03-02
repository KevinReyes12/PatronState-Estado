using System;
using System.Collections.Generic;
using System.Text;

namespace PatronState
{
    class WifiContexto
    {
        public WifiContexto() {
            
        }

        private Estado wEstado;

        public Estado Estado_
        {
            get { return wEstado; }
            set { wEstado = value; }
        }

        //Solicitud
        public void PresionarBoton() {
            wEstado.Respuesta();
        }

    }
}
