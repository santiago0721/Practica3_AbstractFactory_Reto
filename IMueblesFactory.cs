using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_AbstractFactory_Reto       //Interface Abstract Factory
{
    public interface IMueblesFactory
    {
        ISilla CrearSilla();
        IMesa CrearMesa();

    }
}
