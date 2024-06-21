using System.Collections.Generic;
using AccesoDatos;

namespace AccesoDatos.Interfaces
{
    public interface ICategoriasRepository
    {
        IEnumerable<Categorias> GetCategorias();
        Categorias GetCategoria(int id);
        void AddCategoria(Categorias categoria);
        void UpdateCategoria(Categorias categoria);
        void DeleteCategoria(int id);
    }
}

