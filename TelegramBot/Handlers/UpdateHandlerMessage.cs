using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Services
{
    public partial class UpdateHandler
    {
        private async Task HandleMessageAsync(ITelegramBotClient botClient, Message? message, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(message);

            var from = message.From;

            _logger.LogInformation("Receved message from {from.FirstName}: {message.Text}", from?.FirstName, message.Text);
        }
    }
}
