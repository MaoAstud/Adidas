using System.Collections.Generic;
using AccesoDatos.Interfaces;
using Datos;
using Logica.Interfaces;
using AccesoDatos;


namespace Logica.Implementations
{
    public class CategoriasService : ICategoriasService
    {
        private readonly ICategoriasRepository _categoriasRepository;

        public CategoriasService(ICategoriasRepository categoriasRepository)
        {
            _categoriasRepository = categoriasRepository;
        }

        public IEnumerable<Categorias> GetCategorias()
        {
            return _categoriasRepository.GetCategorias();
        }

        public Categorias GetCategoria(int id)
        {
            return _categoriasRepository.GetCategoria(id);
        }

        public void AddCategoria(Categorias categoria)
        {
            _categoriasRepository.AddCategoria(categoria);
        }

        public void UpdateCategoria(Categorias categoria)
        {
            _categoriasRepository.UpdateCategoria(categoria);
        }

        public void DeleteCategoria(int id)
        {
            _categoriasRepository.DeleteCategoria(id);
        }
    }
}

