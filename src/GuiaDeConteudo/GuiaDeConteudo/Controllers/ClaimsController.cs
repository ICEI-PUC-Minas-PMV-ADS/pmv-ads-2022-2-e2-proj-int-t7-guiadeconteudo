using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace GuiaDeConteudo.Controllers
{
    [Authorize]
    public class ClaimsController : Controller
    {
        public ViewResult Index() => View(User?.Claims);
    }
}
