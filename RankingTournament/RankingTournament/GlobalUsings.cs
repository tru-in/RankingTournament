global using System.Collections.Immutable;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Localization;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using RankingTournament.Models;
global using RankingTournament.Presentation;
global using RankingTournament.Services.Endpoints;
global using RankingTournament.DataContracts;
global using RankingTournament.DataContracts.Serialization;
global using RankingTournament.Services.Caching;
global using RankingTournament.Client;
global using Uno.Extensions.Http.Kiota;
#if MAUI_EMBEDDING
global using RankingTournament.MauiControls;
#endif
global using ApplicationExecutionState = Windows.ApplicationModel.Activation.ApplicationExecutionState;
global using Color = Windows.UI.Color;
[assembly: Uno.Extensions.Reactive.Config.BindableGenerationTool(3)]
