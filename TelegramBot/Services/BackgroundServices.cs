using Telegram.Bot;

namespace TelegramBot.Services
{
    public class BackgroundServices : BackgroundService
    {
        private readonly ILogger _logger;
        private readonly TelegramBotClient _botClient;

        public BackgroundServices(ILogger<BackgroundServices> logger ,TelegramBotClient botClient)
        {
            _logger = logger;
            _botClient = botClient;

        }


        public async Task ExecuteAsync()
        {
            _logger.LogInformation(_botClient.GetMeAsync().Result.Username);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var bot = await _botClient.GetMeAsync();
            _logger.LogInformation($"Bot Started Successfully {bot.Username}");
        }
    }
}
