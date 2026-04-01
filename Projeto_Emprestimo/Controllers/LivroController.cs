using Microsoft.AspNetCore.Mvc;
using Projeto_Emprestimo.Models;
using Projeto_Emprestimo.Repositories.Contract;

namespace Projeto_Emprestimo.Controllers
{
    public class LivroController : Controller
    {
        private ILivroRepository _repository;
        public LivroController(ILivroRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Livro livro, IFormFile file)
        {
            var caminho = GerenciaArquivo.GerenciadorArquivo.CadastrarImagemProduto(file);
            livro.imagemLivro = caminho;

            _repository.Cadastrar(livro);

            ViewBag.msg = "Cadastro realizado";
            return View();
        }
    }
}
