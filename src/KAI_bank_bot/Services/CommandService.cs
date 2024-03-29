﻿using KAI_bank_bot.Commands;
using KAI_bank_bot.Interfaces;
using System.Collections.Generic;

namespace KAI_bank_bot.Services
{
    /// <inheritdoc cref="ICommandService"/>
    public class CommandService : ICommandService
    {
        private readonly IEnumerable<ITelegramCommand> _commands;

        /// <summary>
        /// Base constructor.
        /// </summary>
        public CommandService()
        {
            _commands = new List<ITelegramCommand>
            {
                new AboutCommand(),
                new BanksCommand(),
                new RatesNow(),
                new RatesByDate()
            };
        }

        /// <inheritdoc/>
        public IEnumerable<ITelegramCommand> Get() => _commands;
    }
}
