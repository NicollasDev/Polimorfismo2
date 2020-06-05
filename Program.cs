using System;

namespace Polimorfismo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Anime  Infoanime = new Anime();

            System.Console.WriteLine( Infoanime.Poder() );
            
            System.Console.WriteLine( Infoanime.Poder(900) );
            
            Console.WriteLine( Infoanime.Poder(900, 50) );

        }
    }
}
