using Laboratorio.SonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Class
{
    internal class Videojuego : VideojuegoBase
    {
        private string titulo;
        private string desarrolladora;
        private string calificacion;
        private int añoLanzamiento;

        public Videojuego(string titulo, string desarrolladora, string calificacion, int añoLanzamiento)
        {
            this.titulo = titulo;
            this.desarrolladora = desarrolladora;
            this.calificacion = calificacion;
            this.añoLanzamiento = añoLanzamiento;
        }

        private object? ObtenerNivelDificultad()
        {
            throw new NotImplementedException();
        }

        private object? ObtenerPerspectiva()
        {
            throw new NotImplementedException();
        }

        JuegoRPG juegoRPG = new JuegoRPG("Dragon Quest XI", "Square Enix", "9.5", 2017,
                                 "Embárcate en una aventura épica para salvar el reino de Erdrea", "Turnos", 8);

        JuegoDeportes JuegoDeporte = new JuegoDeportes("FiFa", "ElectronicArts", "6.5", 2005);

        JuegosdeAccion JuegosdeAccion = new JuegosdeAccion("Pepapig","ubisoft","10",2023);
    }
}
