using System.Collections.Generic;
using Datos;
using AccesoDatos;
namespace Logica.Interfaces
{
    public interface ICategoriasService
    {
        IEnumerable<Categorias> GetCategorias();
        Categorias GetCategoria(int id);
        void AddCategoria(Categorias categoria);
        void UpdateCategoria(Categorias categoria);
        void DeleteCategoria(int id);
    }
}

