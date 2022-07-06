using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Services
{
    public partial class UpdateHandler
    {
        private async Task HandleEditedMessage(ITelegramBotClient botClient, Message? message, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(message);

            var from = message.From;

            _logger.LogInformation("Receved edited message from {from.FirstName}: {message.Text}", from?.FirstName, message.Text);
        }
    }
}
