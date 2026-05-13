using CarrinhodeCompras.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarrinhodeCompras.Repository.Contract
{
    public interface ICategoriaRepository
    {
        public Task<IViewComponentResult> InvokeAsync();
        public IEnumerable<Categoria> ObterTodasCategorias();
    }
}