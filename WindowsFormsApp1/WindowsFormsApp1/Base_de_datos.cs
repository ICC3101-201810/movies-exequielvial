using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Base_de_datos
    {
        public List<Persona> personas = new List<Persona>();
        public List<Estudio> estudios = new List<Estudio>();
        public List<Pelicula> peliculas = new List<Pelicula>();
        public List<PeliculaActor> peliculaactor = new List<PeliculaActor>();
        public List<PeliculaProductor> peliculaproductor = new List<PeliculaProductor>();
    }
}
