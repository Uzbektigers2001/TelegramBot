using Telegram.Bot;
using Telegram.Bot.Polling;

namespace TelegramBot.Services
{
    public class BackgroundServices : BackgroundService
    {
        private readonly ILogger _logger;
        private readonly TelegramBotClient _botClient;
        private readonly IUpdateHandler _handler;

        public BackgroundServices(ILogger<BackgroundServices> logger ,TelegramBotClient botClient, IUpdateHandler handler)
        {
            _logger = logger;
            _botClient = botClient;
            _handler = handler;

        }


        public async Task ExecuteAsync()
        {
            _logger.LogInformation(_botClient.GetMeAsync().Result.Username);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var bot = await _botClient.GetMeAsync();

            _logger.LogInformation($"Bot Started Successfully {bot.Username}");

            _botClient.StartReceiving(
                _handler.HandleUpdateAsync,
                _handler.HandlePollingErrorAsync,
                new ReceiverOptions()
                {
                    ThrowPendingUpdates = true
                },
                stoppingToken);
        }
    }
}
