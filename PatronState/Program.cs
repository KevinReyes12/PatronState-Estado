using System;

namespace PatronState
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WifiContexto miWifi = new WifiContexto();

            miWifi.Estado_ = new Apagado();
            miWifi.PresionarBoton();

            miWifi.Estado_ = new Encendido();
            miWifi.PresionarBoton();


            Console.ReadKey();
        }
    }
}
