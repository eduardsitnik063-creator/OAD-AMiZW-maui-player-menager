using MauiApp3.Data;
using MauiApp3.Model;
namespace MauiApp3.Commands
{
    public class EditPlayerCommandHandler
    {
        private readonly PlayerRepository _playerRepository;

        public EditPlayerCommandHandler(PlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public void Handle(EditPlayerCommand command)
        {
            var player = _playerRepository.Players.FirstOrDefault(player => player.Id == command.Id);
            if (player != null)
            {
                return;
            }
            Player playerupdate = new Player
            {
                Id = command.Id,
                Name = command.Name,
                Level = command.Level,
            };
        }
    }
}