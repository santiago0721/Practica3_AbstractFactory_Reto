using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_AbstractFactory_Reto            //Concrete Factory
{
    internal class MinimalistaFactory: IMueblesFactory
    {
        public ISilla CrearSilla()
        {
            return new SillaMinimalista();  //Retorna el producto concreto
        }

        public IMesa CrearMesa()
        {
            return new MesaMinimalista();
        }
    }
}
