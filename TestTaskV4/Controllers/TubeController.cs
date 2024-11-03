using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestTaskV4.Interfaces;
using TestTaskV4.Models;

namespace TestTaskV4.Controllers;

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
    public override IActionResult Index()
    {
        var tubes = List.Include(x => x.Pack);
        return View(tubes);
    }

    public IActionResult Add()
    {
        return View();
    }

    /// <summary>
    /// Добавление записи
    /// </summary>
    /// <param name="model">Запись</param>
    /// <returns>Добавленная запись</returns>
    [HttpPost]
    public IActionResult Add(Tube model)
    {
        if (HasDuplicateByName(model) == true)
            return StatusCode(500, "Запись уже существует");

        if (_repository.Add(model).Guid != Guid.Empty)
        {
            return RedirectToAction("Index");
        }

        return BadRequest();
    }
}
