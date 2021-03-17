using ArchivoXML_5.Contracts.Repository;
using ArchivoXML_5.DAL.Serializacion;
using ArchivoXML_5.EE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivoXML_5.BLL
{
    public class XmlBLL : IRepository<Genero>
    {
        private string _ruta;

        public XmlBLL(string ruta)
        {
            _ruta = ruta;
        }

        public List<Genero> GetAll()
        {
            string xml = LeerXML();
            return Deserializar(xml).ListarGenero;
        }

        private GeneroXML Deserializar(string xml)
        {
            try
            {
                Serializacion serializacion = new Serializacion();
                return serializacion.Deserializar<GeneroXML>(xml);
            }
            catch (Exception)
            {

                return new GeneroXML();
            }
        }

        private string LeerXML()
        {
            using (FileStream archivo = new FileStream(_ruta,FileMode.OpenOrCreate))
            {
                TextReader textReader = new StreamReader(archivo);
                return textReader.ReadToEnd();
            }
        }

        public void Save(Genero entity)
        {
            var listar = GetAll();
            listar.Add(entity);
            EscribirXML(listar);
        }

        private void EscribirXML(List<Genero> listar)
        {
            using (FileStream archivo = new FileStream(_ruta, FileMode.OpenOrCreate))
            {
                Serializacion serializacion = new Serializacion();
                StreamWriter streamWriter = new StreamWriter(archivo);
                GeneroXML generoXML = new GeneroXML(listar);
                var s = serializacion.Serializar(generoXML);
                streamWriter.WriteLine(s);
                streamWriter.Flush();
            }
        }
    }
}
