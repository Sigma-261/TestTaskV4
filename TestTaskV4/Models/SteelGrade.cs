using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestTaskV4.Models;

/// <summary>
/// Марка стали
/// </summary>
[Table("STEEL_GRADE")]
public class SteelGrade : Entity
{
    /// <summary>
    /// Вес трубы
    /// </summary>
    [Column("NAME")]
    public required string Name { get; set; }
}
