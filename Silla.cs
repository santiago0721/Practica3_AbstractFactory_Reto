using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_AbstractFactory_Reto        //Concrete Product 
{
    public class SillaMinimalista: ISilla
    {
        public string UsefulFunctionSilla()
        {
            return "Silla Minimalista";
        }
    }

    public class SillaClasica : ISilla
    {
        public string UsefulFunctionSilla()
        {
            return "Silla Clasica";
        }
    }
}
