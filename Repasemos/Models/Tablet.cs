using Repasemos.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasemos.Models
{
    class Tablet : Dispositivo
    {
        private SO sO;
        public Tablet(string marca, string modelo, string pulgadas, SO sO) : base(modelo, pulgadas, sO, marca)
        {
        }
    }
}
