using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kladionica.BazaPodataka.Interfejsi
{
    public interface IDaoCrud<T>
    {
        long create(T entity);
        T read(T entity);
        T update(T entity);
        void delete(T entity);
        T getById(int id);
        List<T> getAll();
        
    }
}
