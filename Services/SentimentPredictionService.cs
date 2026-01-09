using Microsoft.ML;
using ML_WPF.Models;

namespace ML_WPF.Services;

public class SentimentPredictionService
{
    private readonly PredictionEngine<ModelInput, ModelOutput> _predictionEngine;
    private readonly List<ReviewEntry> _history = [];

    public SentimentPredictionService()
    {
        var mlContext = new MLContext();
        var modelPath = Path.Combine(AppContext.BaseDirectory, "MLModels", "MLModel1.mlnet");
        var model = mlContext.Model.Load(modelPath, out _);
        _predictionEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model);
    }

    public bool Predict(string reviewText)
    {
        var input = new ModelInput { Col0 = reviewText };
        var result = _predictionEngine.Predict(input);
        return result.PredictedLabel == 1;
    }

    public void AddToHistory(string text, bool isPositive)
    {
        _history.Insert(0, new ReviewEntry
        {
            Text = text,
            IsPositive = isPositive,
            Timestamp = DateTime.Now
        });
    }

    public IReadOnlyList<ReviewEntry> GetHistory() => _history;

    public void ClearHistory() => _history.Clear();
}
