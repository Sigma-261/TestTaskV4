using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskV4.Models;

public record TubeStatistics
{
    public int TotalCount { get; set; }
    public int DefectCount { get; set; }
    public int QualityCount { get; set; }
    public decimal TotalWeight { get; set; }
}
