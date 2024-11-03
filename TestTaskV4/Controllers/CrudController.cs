﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskV4.Interfaces;
using TestTaskV4.Models;

namespace TestTaskV4.Controllers;

public abstract class CrudController<T> : Controller
    where T : Entity
{
    protected readonly IEntityRepository<T> _repository;
    private readonly ILogger<T> _logger;

    protected CrudController(IEntityRepository<T> repository, ILogger<T> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    /// <summary>
    /// Получение списка записей
    /// </summary>
    protected virtual IQueryable<T> List => _repository.GetListQuery();

    /// <summary>
    /// Получение списка всех записей
    /// </summary>
    /// <returns>Весь список записей</returns>
    [HttpGet]
    public virtual IActionResult Index()
    {
        return View(List);
    }

    /// <summary>
    /// Получение записи
    /// </summary>
    /// <param name="guid">Идентификатор записи</param>
    /// <returns>Запись</returns>
    [HttpGet("{guid:guid}")]
    public virtual IActionResult Get(Guid guid)
    {
        var entity = List.FirstOrDefault(p => p.Guid == guid);

        if (entity == null) return NotFound("Guid не найден");

        return Ok(entity);
    }

    /// <summary>
    /// Удаление записи
    /// </summary>
    /// <param name="guid">Идентификатор записи</param>
    /// <returns></returns>
    [HttpDelete("{guid}")]
    [HttpDelete("delete/{guid}")]
    public virtual IActionResult DeleteByGuid(Guid guid)
    {
        var entity = _repository.Get(guid);
        if (entity == null) return NotFound();

        if (_repository.Delete(guid))
        {
            return Ok();
        }

        return StatusCode(500, "Произошла ошибка при удалении записи");
    }

    /// <summary>
    /// Обновление записи
    /// </summary>
    /// <param name="model">Обновленная запись</param>
    /// <returns></returns>
    [HttpPut]
    public virtual IActionResult Update(T model)
    {
        var fromDb = _repository.Get(model.Guid);
        if (fromDb == null) return BadRequest("Запись с заданным идентификатором не найдена");

        if (_repository.Update(model))
            return Ok(model);

        return StatusCode(500, "Не удалось обновить запись");
    }

    [NonAction]
    protected bool? HasDuplicateByName(T model)
    {
        System.Reflection.PropertyInfo[]? childProperties = typeof(T).GetProperties(System.Reflection.BindingFlags.Public
          | System.Reflection.BindingFlags.Instance
          | System.Reflection.BindingFlags.DeclaredOnly);

        if (childProperties.Length == 1 && childProperties[0].Name == "Name")
        {
            bool hasDuplicate = _repository.GetListQuery().ToList()
                .Any(x => x.Guid != model.Guid && (string)x.GetType().GetProperty("Name").GetValue(x, null)
                == (string)model.GetType().GetProperty("Name").GetValue(model, null));

            return hasDuplicate;
        }

        return false;
    }
}
