using EcomerceApp.Data;
using EcomerceApp.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcomerceApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View(data);
        }
    }
}
