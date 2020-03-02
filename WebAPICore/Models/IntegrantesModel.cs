using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICore.Models
{
    [Serializable]
    public class IntegrantesModel
    {
        private int id;
        private string nombre;
        private string nommedio;
        private string apellido;
        private string sexo;
        private DateTime fnacim;
        private DateTime ffallec;
        private int ciudadnac;
        private int nacionalidad;
        private int padre;
        private int madre;
        private int esposo;
        private int esposa;

        private List<PadreMadreModel> padreMadre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Nommedio { get => nommedio; set => nommedio = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime Fnacim { get => fnacim; set => fnacim = value; }
        public DateTime Ffallec { get => ffallec; set => ffallec = value; }
        public int Ciudadnac { get => ciudadnac; set => ciudadnac = value; }
        public int Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public int Padre { get => padre; set => padre = value; }
        public int Madre { get => madre; set => madre = value; }
        public int Esposo { get => esposo; set => esposo = value; }
        public int Esposa { get => esposa; set => esposa = value; }
        public List<PadreMadreModel> PadreMadre { get => padreMadre; set => padreMadre = value; }
    }
}
