﻿using KAI_bank_bot.Interfaces;
using KAI_bank_bot.Resources;
using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace KAI_bank_bot.Commands
{
    /// <inheritdoc cref="ITelegramCommand"/>
    public class AboutCommand : ITelegramCommand
    {
        /// <inheritdoc/>
        public string Name { get; } = About.Start;

        /// <inheritdoc/>
        public async Task Execute(Message message, ITelegramBotClient client)
        {
            try
            {
                var chatId = message.Chat.Id;
                await client.SendTextMessageAsync(chatId,$"{About.Message}\U0001F44B\n{About.Message2}\n{About.Message3}\n\n{About.Message4}\n");
            }
            catch (Exception)
            {
                var chatId = message.Chat.Id;
                await client.SendTextMessageAsync(chatId, Exceptions.OtherExeption);
            }
        }

        /// <inheritdoc/>
        public bool Contains(Message message) => message != null && message.Type == MessageType.Text && message.Text.Contains(Name);
    }
}
