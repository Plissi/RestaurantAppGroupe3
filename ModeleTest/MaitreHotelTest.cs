using System;
using System.Collections.Generic;
using System.Text;

namespace ModeleTest
{
    class MaitreHotelTest
    {
        static void main (string[] ars)
        {
            int nombreClient = 0;
            int resultat = AccueillirClient(nombreClient);
            if (resultat < 1)
            {
                Console.WriteLine("le test a echoué");
            }
        }

        private static int AccueillirClient(int a)
        {
            return 0;
        }
    }
}
