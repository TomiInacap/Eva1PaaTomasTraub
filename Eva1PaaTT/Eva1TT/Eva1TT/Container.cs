using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva1TT
{
    internal class Container
    {
        /* Estructura Clase Container*/
        private string codigo;
        private string marca;
        private int capacidadMaxima;
        private byte tamaño;
        private bool esRefrigerado;
        private int pesoActual;
        public Buque buque;


        public string Codigo { get => codigo; }
        public string Marca { get => marca; set => marca = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public byte Tamaño { get => tamaño; set => tamaño = value; }
        public bool EsRefrigerado { get => esRefrigerado; set => esRefrigerado = value; }
        public int PesoActual { get => pesoActual; set => pesoActual = value; }
        public Buque Buque { get => buque; }

        public Container()
        {
        }

        public Container(string codigo, string marca, int capacidadMaxima, byte tamaño, bool esRefrigerado, int pesoActual, Buque buque)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.capacidadMaxima = capacidadMaxima;
            this.tamaño = tamaño;
            this.esRefrigerado = esRefrigerado;
            this.pesoActual = pesoActual;
            this.buque = buque;
        }
    }
}
