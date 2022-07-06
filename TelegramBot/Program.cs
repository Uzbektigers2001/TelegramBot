using Telegram.Bot;
using Telegram.Bot.Polling;
using TelegramBot.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton(p => new TelegramBotClient(builder.Configuration.GetValue("BotToken", string.Empty)));
builder.Services.AddSingleton<IUpdateHandler, UpdateHandler>();
builder.Services.AddHostedService<BackgroundServices>();

var app = builder.Build();

app.Run();
