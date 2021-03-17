using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivoXML_5.Contracts.Repository
{
    public interface IRepository<T>
    {
        void Save(T entity);

        List<T> GetAll();
    }
}
