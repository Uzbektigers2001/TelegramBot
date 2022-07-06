using Telegram.Bot;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton(new TelegramBotClient(builder.Configuration.GetValue("BotToken", string.Empty)));

var app = builder.Build();

app.Run();
