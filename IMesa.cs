using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_AbstractFactory_Reto
{
    public interface IMesa      //Interface Abstract Product
    {
        string UsefulFunctionMesa();
        string AnotherUsefulFunctionMesa(ISilla collabolator);  
    }
}
