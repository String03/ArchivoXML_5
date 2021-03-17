using ArchivoXML_5.Contracts.Serializacion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ArchivoXML_5.DAL.Serializacion
{
    public class Serializacion : ISerializacion
    {
        public T Deserializar<T>(string xml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            TextReader textReader = new StringReader(xml);
            return (T)xmlSerializer.Deserialize(textReader);
        }

        public string Serializar<T>(T entity)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            MemoryStream memoryStream = new MemoryStream();
            xmlSerializer.Serialize(memoryStream, entity);
            return Encoding.ASCII.GetString(memoryStream.ToArray());
        }
    }
}
