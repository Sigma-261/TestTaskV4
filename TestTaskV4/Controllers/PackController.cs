using Microsoft.AspNetCore.Mvc;
using TestTaskV4.Interfaces;
using TestTaskV4.Models;

namespace TestTaskV4.Controllers;

public class PackController : CrudController<Pack>
{
    private readonly IEntityRepository<Pack> _packRepository;
    private readonly IEntityRepository<Tube> _tubeRepository;
    private ILogger<Pack> _logger;
    public PackController(IEntityRepository<Pack> packRepository,
        IEntityRepository<Tube> tubeRepository,
        ILogger<Pack> logger) : base(packRepository, logger)
    {
        _packRepository = packRepository;
        _tubeRepository = tubeRepository;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var packs = List;
        return View(packs);
    }
}
