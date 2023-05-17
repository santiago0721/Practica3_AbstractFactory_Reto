using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_AbstractFactory_Reto       //Concrete Product 
{
    public class MesaMinimalista : IMesa
    {
        public string UsefulFunctionMesa()
        {
            return "Mesa Minimalista";
        }

        public string AnotherUsefulFunctionMesa(ISilla collaborator)
        {
            var result = collaborator.UsefulFunctionSilla();
            return $"Mesa Minimalista con ({result})";
        }
    }

    public class MesaClasica : IMesa
    {
        public string UsefulFunctionMesa()
        {
            return "Mesa Clasica";
        }
        public string AnotherUsefulFunctionMesa(ISilla collaborator)
        {
            var result = collaborator.UsefulFunctionSilla();
            return $"Mesa Clásica con ({result})";
        }
    }
}
