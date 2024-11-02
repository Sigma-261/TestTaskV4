using Microsoft.AspNetCore.Mvc;
using TestTaskV4.Interfaces;
using TestTaskV4.Models;

namespace TestTaskV4.Controllers
{
    public class GradeController : CrudController<SteelGrade>
    {
        private readonly IEntityRepository<SteelGrade> _gradeRepository;
        private ILogger<SteelGrade> _logger;
        public GradeController(IEntityRepository<SteelGrade> gradeRepository,
            ILogger<SteelGrade> logger) : base(gradeRepository, logger)
        {
            _gradeRepository = gradeRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var grades = List;
            return View(grades);
        }
    }
}
