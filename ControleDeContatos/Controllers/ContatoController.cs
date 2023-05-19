using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    //Essa Classe é criada automaticamente quando voce vai em adcionar -> controller
    public class ContatoController : Controller //Classe de controle
    {
        public IActionResult Index() //Por Padrão ja vem com a Action Index (importante criar a View com o mesmo nome da Action)
        {
            return View(); //Clicar com botão direito, e adcionar View (Exibição) vazia. com nome Index.cshtml
        }

        public IActionResult Adicionar()
        {
            return View(); //Importante criar a View com o mesmo nome da Action
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }
    }
}
