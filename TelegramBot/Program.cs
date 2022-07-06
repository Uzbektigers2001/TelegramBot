using Telegram.Bot;
using TelegramBot.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton(new TelegramBotClient(builder.Configuration.GetValue("BotToken", string.Empty)));
builder.Services.AddHostedService<BackgroundServices>();

var app = builder.Build();

app.Run();
