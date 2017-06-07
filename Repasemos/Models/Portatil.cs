using Repasemos.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasemos.Models
{
    class Portatil : Dispositivo
    {
        private RAM Ram;
        private String Procesador;

        public Portatil(string marca, string modelo, string pulgadas, string sO, RAM ram, string procesador) :
            base(marca, modelo, pulgadas, sO, ram, procesador)
        {
        }
    }
}
