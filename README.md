# ML_WPF - Sentiment Analyse

Eine ASP.NET Core Razor Pages Webanwendung zur Sentiment-Analyse von Rezensionen mit ML.NET. Es wurden circa 3000 Trainingsdaten für 120 Sekunden trainiert mt dem Modell LbfgsLogisticRegressionOva und einer MacroAccuracy von 0,7895

## Voraussetzungen

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

## Installation & Start

```bash
git clone https://github.com/N1tschi/ML_WPF.git
cd ML_WPF
dotnet run
```

Browser öffnen: **http://localhost:5155**

## Features

- **Landing Page** - Übersicht und Navigation
- **Binary Classification** - Rezensionen als positiv/negativ bewerten
- **Verlauf** - Alle Bewertungen der Session werden angezeigt

## Technologien

- ASP.NET Core Razor Pages
- ML.NET (Binary Classification)
- Bulma CSS
