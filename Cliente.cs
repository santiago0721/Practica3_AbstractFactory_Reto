using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_AbstractFactory_Reto
{
    internal class Cliente
    {
        public void Main() 
        {
            Console.WriteLine("---");
            ClientMethod(new ClasicoFactory());
            Console.WriteLine();

            Console.WriteLine("---");
            ClientMethod(new MinimalistaFactory());
        }

        public void ClientMethod(IMueblesFactory factory)
        {
            var silla = factory.CrearSilla();
            var mesa = factory.CrearMesa();

            Console.WriteLine(mesa.UsefulFunctionMesa());
            Console.WriteLine(mesa.AnotherUsefulFunctionMesa(silla));

        }
    }
}
