using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivoXML_5.EE
{
    public class GeneroXML
    {
        public List<Genero> ListarGenero { get; set; } = new List<Genero>();

        public GeneroXML()
        {

        }

        public GeneroXML(List<Genero> listarGenero)
        {
            ListarGenero = listarGenero;
        }
    }
}
