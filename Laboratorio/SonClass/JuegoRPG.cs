using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.SonClass
{

    public class JuegoRPG : VideoJuego
    {
        private string historia;
        private string sistemaCombate;
        private int numeroClases;

        public JuegoRPG(string titulo, string desarrolladora, string calificacion, int añoLanzamiento,
                         string historia, string sistemaCombate, int numeroClases)
            : base(titulo, desarrolladora, calificacion, añoLanzamiento)
        {
            this.historia = historia;
            this.sistemaCombate = sistemaCombate;
            this.numeroClases = numeroClases;
        }

        public JuegoRPG(string historia, string sistemaCombate, int numeroClases)
        {
            this.historia = historia;
            this.sistemaCombate = sistemaCombate;
            this.numeroClases = numeroClases;
        }

        public string ObtenerHistoria()
        {
            return historia;
        }

        public string ObtenerSistemaCombate()
        {
            return sistemaCombate;
        }

        public int ObtenerNumeroClases()
        {
            return numeroClases;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Historia: {0}", ObtenerHistoria());
            Console.WriteLine("Sistema de combate: {0}", ObtenerSistemaCombate());
            Console.WriteLine("Número de clases: {0}", ObtenerNumeroClases());
        }

        private object? ObtenerTitulo()
        {
            throw new NotImplementedException();
        }

        public void SeleccionarClase()
        {
            Console.WriteLine("Elige tu clase:");
            for (int i = 1; i <= ObtenerNumeroClases(); i++)
            {
                Console.WriteLine("{0}. Clase {1}", i, i);
            }

            int seleccion = int.Parse(Console.ReadLine());

            if (seleccion > 0 && seleccion <= ObtenerNumeroClases())
            {
                Console.WriteLine("¡Has elegido la clase {0}!", seleccion);
            }
            else
            {
                Console.WriteLine("Selección inválida. Intenta de nuevo.");
            }

            JuegoRPG juegoRPG = new JuegoRPG("Dragon Quest XI", "Square Enix", "9.5", 2017,
                                 "Embárcate en una aventura épica para salvar el reino de Erdrea", "Turnos", 8);
        }
    }

}
