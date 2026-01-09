using Microsoft.ML.Data;

namespace ML_WPF.Models;

public class ModelInput
{
    [LoadColumn(0)]
    [ColumnName(@"col0")]
    public string Col0 { get; set; } = string.Empty;

    [LoadColumn(1)]
    [ColumnName(@"col1")]
    public float Col1 { get; set; }
}
