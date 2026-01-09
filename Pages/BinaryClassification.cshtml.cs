using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ML_WPF.Models;
using ML_WPF.Services;

namespace ML_WPF.Pages;

public class BinaryClassificationModel : PageModel
{
    private readonly SentimentPredictionService _predictionService;

    public BinaryClassificationModel(SentimentPredictionService predictionService)
    {
        _predictionService = predictionService;
    }

    [BindProperty]
    public string ReviewText { get; set; } = string.Empty;

    public bool ShowResult { get; set; }
    public bool IsPositive { get; set; }
    public IReadOnlyList<ReviewEntry> History => _predictionService.GetHistory();

    public void OnGet()
    {
    }

    public void OnPost()
    {
        if (string.IsNullOrWhiteSpace(ReviewText))
        {
            return;
        }

        IsPositive = _predictionService.Predict(ReviewText);
        _predictionService.AddToHistory(ReviewText, IsPositive);
        ShowResult = true;
    }
}
