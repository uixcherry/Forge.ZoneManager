using Rocket.API;
using Rocket.Unturned.Player;
using System.Collections.Generic;

namespace Forge.ZoneManager.Commands
{
    public class CommandZone : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;
        public string Name => "zone";
        public string Help => "";
        public string Syntax => "";
        public List<string> Aliases => new List<string>();
        public List<string> Permissions => new List<string> { "forge.zone" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;


        }
    }
}