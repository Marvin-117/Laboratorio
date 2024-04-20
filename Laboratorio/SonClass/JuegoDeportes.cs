using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.SonClass
{

    public class JuegoDeportes : VideoJuego
    {
        private string deporte;
        private string equiposDisponibles;

        public JuegoDeportes(string titulo, string desarrolladora, string calificacion, int añoLanzamiento, string deporte, string equiposDisponibles)
            : base(titulo, desarrolladora, calificacion, añoLanzamiento)
        {
            this.deporte = deporte;
            this.equiposDisponibles = equiposDisponibles;
        }

        public JuegoDeportes(string deporte, string equiposDisponibles)
        {
            this.deporte = deporte;
            this.equiposDisponibles = equiposDisponibles;
        }

        public JuegoDeportes(string titulo, string desarrolladora, string calificacion1, int añoLanzamiento) : base(titulo, desarrolladora, calificacion1, añoLanzamiento)
        {
        }

        public string ObtenerDeporte()
        {
            return deporte;
        }

        public

    }
    
