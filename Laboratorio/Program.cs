using System;

namespace LaboratorioProgra1.Laboratorio
{
    /// <summary>
    /// Esta Clase Padre tiene 4 errores lógicos
    /// debe de encontrarlos y corregirlos
    /// documente los errores encontrados y las correcciones realizadas
    /// </summary>
    internal class VideoJuego
    {
        private string titulo;
        private string desarrolladora;
        private double calificacion;
        private int anioLanzamiento;
        private bool jugando;
        private string calificacion1;
        private int añoLanzamiento;

        public VideoJuego(string titulo, string desarrolladora, string calificacion1, int añoLanzamiento)
        {
            this.titulo = titulo;
            this.desarrolladora = desarrolladora;
            this.calificacion1 = calificacion1;
            this.añoLanzamiento = añoLanzamiento;
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Desarrolladora
        {
            get { return desarrolladora; }
            set { desarrolladora = value; }
        }

        public double Calificacion
        {
            get { return calificacion; }
            set
            {
                // La calificación debe estar entre 0 y 10
                if (value < 0 || value > 10)
                {
                    Console.WriteLine("La calificación debe estar entre 0 y 10");
                }
                else
                {
                    calificacion = value;
                }
            }
        }

        public int AnioLanzamiento
        {
            get { return anioLanzamiento; }
            set
            {
                // Validación del año de lanzamiento
                if (value > 0)
                {
                    anioLanzamiento = value;
                }
                else
                {
                    Console.WriteLine("El año de lanzamiento debe ser un número positivo.");
                }
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Desarrolladora: " + Desarrolladora);
            Console.WriteLine("Calificación: " + Calificacion);
            Console.WriteLine("Año de Lanzamiento: " + AnioLanzamiento);
        }

        public static void saludo()
        {
            Console.WriteLine("Hi Gamer:");
        }

        public void IniciarPartida()
        {
            jugando = true;
            Console.WriteLine("¡Partida iniciada!");
        }

        public void DetenerPartida()
        {
            // Detener la partida
            jugando = false;
            Console.WriteLine("Partida detenida.");
        }

        public void TerminarJuego()
        {
            // Comprobar si la partida está en curso
            if (jugando)
            {
                // Terminar la partida
                jugando = false;
                Console.WriteLine("Juego terminado.");
            }
            else
            {
                Console.WriteLine("No hay partida en curso.");
            }
        }

        public override void IniciarPartida()
        {
            object value = base.IniciarPartida();
            Console.WriteLine("¡Embárcate en una épica aventura en {0}!", ObtenerTitulo());
        }

    }

}