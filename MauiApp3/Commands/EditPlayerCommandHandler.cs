using MauiApp3.Data;
using MauiApp3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp3.Commands
{
    public class EditPlayerCommandHandler
    {
        private readonly PlayerRepository _playerRepository;
        public EditPlayerCommandHandler(PlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public bool Handle(EditPlayerCommand command)
        {
            var player = _playerRepository.Players.FirstOrDefault(player => player.Id == command.Id);
            if (player == null)
            {
                return false;
            }
            player.Name = command.Name;
            player.Level = command.Level;
            return true;
        }
    }
}