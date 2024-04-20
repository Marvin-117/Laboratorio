using Laboratorio.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.SonClass
{
    internal class JuegosdeAccion : Videojuego
    {
        
            private string perspectiva;
            private int nivelDificultad;

            public JuegosdeAccion(string titulo, string desarrolladora, string calificacion, int añoLanzamiento, string perspectiva, int nivelDificultad)
                : base(titulo, desarrolladora, calificacion, añoLanzamiento)
            {
                this.perspectiva = perspectiva;
                this.nivelDificultad = nivelDificultad;
            }

        public JuegosdeAccion(string titulo, string desarrolladora, string calificacion, int añoLanzamiento) : base(titulo, desarrolladora, calificacion, añoLanzamiento)
        {
        }

        public string ObtenerPerspectiva()
            {
                return perspectiva;
            }

            public int ObtenerNivelDificultad()
            {
                return nivelDificultad;
            }
    }
}
