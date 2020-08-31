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
    public class StartCommand : ITelegramCommand
    {
        /// <inheritdoc/>
        public string Name { get; } = Start.Link;

        /// <inheritdoc/>
        public async Task Execute(Message message, ITelegramBotClient client)
        {
            try
            {
                var chatId = message.Chat.Id;
                await client.SendTextMessageAsync(chatId,$"{Start.Message}\U0001F44B\n{Start.Message2}\n{Start.Message3}\n\n{Start.Message4}\n");
            }
            catch (Exception)
            {
                var chatId = message.Chat.Id;
                await client.SendTextMessageAsync(chatId, Exceptions.OtherExсeption);
            }
        }

        /// <inheritdoc/>
        public bool Contains(Message message) => message != null && message.Type == MessageType.Text && message.Text.Contains(Name);
    }
}