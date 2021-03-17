using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivoXML_5.Contracts.Serializacion
{
    public interface ISerializacion
    {
        string Serializar<T>(T entity);

        T Deserializar<T>(string xml);
    }
}
