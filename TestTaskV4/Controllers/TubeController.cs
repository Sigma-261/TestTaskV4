using Microsoft.AspNetCore.Mvc;
using TestTaskV4.Interfaces;
using TestTaskV4.Models;

namespace TestTaskV4.Controllers
{
    public class TubeController : CrudController<Tube>
    {
        private readonly IEntityRepository<Tube> _tubeRepository;
        private ILogger<Tube> _logger;
        public TubeController(IEntityRepository<Tube> tubeRepository,
            ILogger<Tube> logger) : base(tubeRepository, logger)
        {
            _tubeRepository = tubeRepository;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var tubes = List;
            return View(tubes);
        }
    }
}
