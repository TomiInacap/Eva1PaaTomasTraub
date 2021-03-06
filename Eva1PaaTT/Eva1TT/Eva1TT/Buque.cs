using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva1TT
{
    internal class Buque
    {
        /* Estructura Clase Buque*/
        private string codigo;
        private string nombre;
        private string pais;
        private int cantidadContainers;
        private int cantidadContainersCargados;
        private int gastoTransporte;
        private List<Container> listaContainers;


        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public int CantidadContainers { get => cantidadContainers; set => cantidadContainers = value; }
        public int CantidadContainersCargados { get => cantidadContainersCargados; set => cantidadContainersCargados = value; }
        public int GastoTransporte { get => gastoTransporte; set => gastoTransporte = value; }
        public List<Container> ListaContainers { get => listaContainers; }

        public Buque()
        {
        }

        public Buque(string codigo, string nombre, string pais, int cantidadContainers, int cantidadContainersCargados, int gastoTransporte)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.pais = pais;
            this.cantidadContainers = cantidadContainers;
            this.cantidadContainersCargados = cantidadContainersCargados;
            this.gastoTransporte = gastoTransporte;
            this.listaContainers = listaContainers;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}

