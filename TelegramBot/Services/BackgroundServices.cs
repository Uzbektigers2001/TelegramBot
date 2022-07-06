using Telegram.Bot;

namespace TelegramBot.Services
{
    public class BackgroundServices
    {
        private readonly ILogger _logger;
        private readonly TelegramBotClient _botClient;

        public BackgroundServices(ILogger logger ,TelegramBotClient botClient)
        {
            _logger = logger;
            _botClient = botClient;

        }


        public async Task ExecuteAsync()
        {
            _logger.LogInformation(_botClient.GetMeAsync().Result.Username);
        } 

    }
}
