using Repasemos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repasemos.Enumeraciones;

namespace Repasemos.Models
{

    abstract class Dispositivo : Irreparable
    {
        private String Marca;
        private String Modelo;
        private String Pulgadas;
        private SO SO;
        private String So;
        private Random rnd = new Random();
        private string fuentealimentacion;
        private RAM ram;
        private string procesador;

        public Dispositivo(string modelo, string pulgadas, SO sO, string marca)
        {
            Marca1 = marca;
            Modelo1 = modelo;
            Pulgadas1 = pulgadas;
            SO = sO;
        }
        public Dispositivo(string marca, string modelo,  string sO)
        {
            Marca1 = marca;
            Modelo1 = modelo;
            SO1 = sO;
        }

        public Dispositivo(string marca, string modelo, string pulgadas, string So, string fuentealimentacion, RAM ram, string procesador) : this(modelo, pulgadas, So, marca)
        {
            this.fuentealimentacion = fuentealimentacion;
            this.ram = ram;
            this.procesador = procesador;
        }

        public Dispositivo(string marca, string modelo, string pulgadas, string So, RAM ram, string procesador) : this(modelo, pulgadas, So, marca)
        {
            this.ram = ram;
            this.procesador = procesador;
        }

        public Dispositivo(string marca, string modelo, string sO, string marca1) : this(marca, modelo, sO)
        {
            this.Marca1 = marca1;
        }

        public string Marca1
        {
            get
            {
                return Marca;
            }

            set
            {
                Marca = value;
            }
        }

        public string Modelo1
        {
            get
            {
                return Modelo;
            }

            set
            {
                Modelo = value;
            }
        }

        public string Pulgadas1
        {
            get
            {
                return Pulgadas;
            }

            set
            {
                Pulgadas = value;
            }
        }

        public string SO1
        {
            get
            {
                return So;
            }

            set
            {
                So = value;
            }
        }
        public string ToString()
        {
            return Marca +" de modelo "+ Modelo+ " Con SO " + So + SO;
        }
        public string GenerarMAC()
        {
            char[] aleatorio = {'A','B','C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q'
            ,'R','S','T','U','V','W','X','Y','Z'};
            int x = rnd.Next(1, 10000);
            int y = rnd.Next(1, 28);
            char z = aleatorio[y];
            String Mac = (x +"-"+z);
            return Mac;
        }

        public float precio()
        {
            throw new NotImplementedException();
        }

        public void reparar(float precio)
        {
            throw new NotImplementedException();
        }
    }
}
