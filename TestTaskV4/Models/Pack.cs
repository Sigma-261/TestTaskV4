using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TestTaskV4.Models;

/// <summary>
/// Пакет с трубами
/// </summary>
[Table("PACK")]
public class Pack : Entity
{
    /// <summary>
    /// Номер пакета
    /// </summary>
    [Column("NUMBER")]
    public int Number {  get; set; }

    /// <summary>
    /// Список труб в пакете
    /// </summary>
    public List<Tube> Tubes { get; set; }
}
