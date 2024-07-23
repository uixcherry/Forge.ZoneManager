using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System.Collections.Generic;

namespace Forge.ZoneManager.Commands
{
    public class CommandZone : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;
        public string Name => "zone";
        public string Help => "Manage zones on the server.";
        public string Syntax => "/zone <command> [arguments]";
        public List<string> Aliases => new List<string>();
        public List<string> Permissions => new List<string> { "forge.zone" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;

            if (command.Length == 0)
            {
                HandleHelpCommand(player);
                return;
            }

            switch (command[0].ToLower())
            {
                case "help":
                    HandleHelpCommand(player);
                    break;

                case "add":
                    if (command.Length < 2)
                    {
                        UnturnedChat.Say(player, "Usage: /zone add <zone|node|flag|block|group|message> [arguments]");
                        return;
                    }
                    switch (command[1].ToLower())
                    {
                        case "zone":
                            HandleAddZoneCommand(player, command);
                            break;
                        case "node":
                            HandleAddNodeCommand(player, command);
                            break;
                        case "flag":
                            HandleAddFlagCommand(player, command);
                            break;
                        case "block":
                            HandleAddBlockCommand(player, command);
                            break;
                        case "group":
                            HandleAddGroupCommand(player, command);
                            break;
                        case "message":
                            HandleAddMessageCommand(player, command);
                            break;
                        default:
                            UnturnedChat.Say(player, "Invalid subcommand for /zone add");
                            break;
                    }
                    break;

                case "visualize":
                    if (command.Length < 2)
                    {
                        UnturnedChat.Say(player, "Usage: /zone visualize <nodes|border> <zonename> <on|off>");
                        return;
                    }
                    switch (command[1].ToLower())
                    {
                        case "nodes":
                            HandleVisualizeNodesCommand(player, command);
                            break;
                        case "border":
                            HandleVisualizeBorderCommand(player, command);
                            break;
                        default:
                            UnturnedChat.Say(player, "Invalid subcommand for /zone visualize");
                            break;
                    }
                    break;

                default:
                    UnturnedChat.Say(player, "Invalid command. Use /zone help for a list of commands.");
                    break;
            }
        }

        private void HandleHelpCommand(UnturnedPlayer player)
        {
            
        }

        private void HandleAddCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleVisualizeCommand(UnturnedPlayer player, string[] command)
        {
            
        }
        private void HandleAddZoneCommand(UnturnedPlayer player, string[] command)
        {

        }

        private void HandleAddNodeCommand(UnturnedPlayer player, string[] command)
        {

        }

        private void HandleAddFlagCommand(UnturnedPlayer player, string[] command)
        {

        }

        private void HandleAddBlockCommand(UnturnedPlayer player, string[] command)
        {

        }

        private void HandleAddGroupCommand(UnturnedPlayer player, string[] command)
        {

        }

        private void HandleAddMessageCommand(UnturnedPlayer player, string[] command)
        {

        }

        private void HandleVisualizeNodesCommand(UnturnedPlayer player, string[] command)
        {

        }

        private void HandleVisualizeBorderCommand(UnturnedPlayer player, string[] command)
        {

        }
    }
}