using Repasemos.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasemos.Models
{
    class Pc : Dispositivo
    {
        private String FuenteAlimentacion;
        private RAM Ram;
        private String Procesador;

        public Pc(string marca, string modelo, string pulgadas, string sO, string fuentealimentacion, RAM ram, string procesador) :
            base(marca, modelo, pulgadas, sO, fuentealimentacion, ram, procesador)
        {
        }
    }
}
