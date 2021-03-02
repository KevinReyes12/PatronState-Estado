using System;
using System.Collections.Generic;
using System.Text;

namespace PatronState
{
    class Apagado:Estado
    {
        //Manejar o Handle
        public override void Respuesta()
        {
            Console.WriteLine("¡El Wifi está apagado!");
        }
    }
}
