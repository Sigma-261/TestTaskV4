using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using System.Text.Json.Serialization;
using TestTaskV4.Enum;

namespace TestTaskV4.Models;

/// <summary>
/// Труба
/// </summary>
[Table("TUBE")]
public class Tube : Entity
{
    /// <summary>
    /// Номер трубы
    /// </summary>
    [Column("NUMBER")]
    public int Number {  get; set; }

    /// <summary>
    /// Является ли труба бракованной
    /// </summary>
    [Column("IS_DEFECT")]
    public bool IsDefect { get; set; }

    /// <summary>
    /// Марка стали
    /// </summary>
    [Column("GRADE")]
    public Grade Grade { get; set; }

    /// <summary>
    /// Размер трубы
    /// </summary>
    [Column("SIZE")]
    public decimal Size { get; set; }

    /// <summary>
    /// Вес трубы
    /// </summary>
    [Column("WEIGHT")]
    public decimal Weight { get; set; }

    /// <summary>
    /// Идентификатор Пакета
    /// </summary>
    [Column("ID_PACK")]
    public Guid? IdPack { get; set; }

    /// <summary>
    /// Пакет
    /// </summary>
    [ForeignKey("IdPack")]
    [JsonIgnore]
    public Pack? Pack { get; set; }
}
