using Microsoft.AspNetCore.Mvc;

namespace DotNetTestMVC.Controllers
{
    public class PersonController : Controller
    {

        public string Index()
        {
            return "Olá Mundo. Beleza?";
        }
    }
}
