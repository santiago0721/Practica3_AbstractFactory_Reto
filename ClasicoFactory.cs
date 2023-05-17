using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static Practica3_AbstractFactory_Reto.ClasicoFactory;
using static Practica3_AbstractFactory_Reto.MinimalistaFactory;

namespace Practica3_AbstractFactory_Reto       //Concrete Factory
{
    internal class ClasicoFactory: IMueblesFactory
    {
        public ISilla CrearSilla()
        {
            return new SillaClasica();
        }

        public IMesa CrearMesa()
        {
            return new MesaClasica();
        }
        
    }
}
