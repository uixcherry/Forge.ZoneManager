using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System.Collections.Generic;
using UnityEngine;

namespace Forge.ZoneManager.Commands
{
    public class CommandZone : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;
        public string Name => "zone";
        public string Help => "Manage zones on the server.";
        public string Syntax => "/zone <command> [arguments]";
        public List<string> Aliases => new List<string> { "z" };
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
                case "add":
                    HandleAddCommand(player, command);
                    break;

                case "remove":
                    HandleRemoveCommand(player, command);
                    break;

                case "replace":
                    HandleReplaceCommand(player, command);
                    break;

                case "list":
                    HandleListCommand(player, command);
                    break;

                case "inzone":
                    HandleInZoneCommand(player, command);
                    break;

                case "tp":
                    HandleTpCommand(player, command);
                    break;

                case "flags":
                    HandleFlagsCommand(player, command);
                    break;

                case "blocklist":
                    HandleBlockListCommand(player, command);
                    break;

                case "visualize":
                case "show":
                    HandleVisualizeOrShowCommand(player, command);
                    break;

                default:
                    UnturnedChat.Say(player, "Invalid command. Use /zone help for a list of commands.");
                    break;
            }
        }

        private void HandleHelpCommand(UnturnedPlayer player)
        {
            UnturnedChat.Say(player, Syntax);
        }

        private void HandleAddCommand(UnturnedPlayer player, string[] command)
        {
            if (command.Length < 2)
            {
                UnturnedChat.Say(player, "Usage: /zone add <zone|node|flag|block|parameter|heightnode> [arguments]");
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
                case "parameter":
                    HandleAddParameterCommand(player, command);
                    break;
                case "heightnode":
                    HandleAddHeightNodeCommand(player, command);
                    break;
                default:
                    UnturnedChat.Say(player, "Invalid subcommand for /zone add");
                    break;
            }
        }

        private void HandleRemoveCommand(UnturnedPlayer player, string[] command)
        {
            if (command.Length < 2)
            {
                UnturnedChat.Say(player, "Usage: /zone remove <zone|node|flag|block|parameter|heightnode> [arguments]");
                return;
            }
            switch (command[1].ToLower())
            {
                case "zone":
                    HandleRemoveZoneCommand(player, command);
                    break;
                case "node":
                    HandleRemoveNodeCommand(player, command);
                    break;
                case "flag":
                    HandleRemoveFlagCommand(player, command);
                    break;
                case "block":
                    HandleRemoveBlockCommand(player, command);
                    break;
                case "parameter":
                    HandleRemoveParameterCommand(player, command);
                    break;
                case "heightnode":
                    HandleRemoveHeightNodeCommand(player, command);
                    break;
                default:
                    UnturnedChat.Say(player, "Invalid subcommand for /zone remove");
                    break;
            }
        }

        private void HandleReplaceCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleListCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleInZoneCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleTpCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleFlagsCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleBlockListCommand(UnturnedPlayer player, string[] command)
        {
            if (command.Length < 2)
            {
                UnturnedChat.Say(player, "Usage: /zone blocklist <add|remove|list|additem|removeitem> [arguments]");
                return;
            }
            switch (command[1].ToLower())
            {
                case "add":
                    HandleBlockListAddCommand(player, command);
                    break;
                case "remove":
                    HandleBlockListRemoveCommand(player, command);
                    break;
                case "list":
                    HandleBlockListListCommand(player, command);
                    break;
                case "additem":
                    HandleBlockListAddItemCommand(player, command);
                    break;
                case "removeitem":
                    HandleBlockListRemoveItemCommand(player, command);
                    break;
                default:
                    UnturnedChat.Say(player, "Invalid subcommand for /zone blocklist");
                    break;
            }
        }

        private void HandleVisualizeOrShowCommand(UnturnedPlayer player, string[] command)
        {
            if (command.Length < 4)
            {
                UnturnedChat.Say(player, "Invalid! Try /zone visualize <nodes|border> <zonename> <on|off> <space>", Color.red);
                return;
            }
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

        private void HandleAddParameterCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleAddHeightNodeCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleRemoveZoneCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleRemoveNodeCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleRemoveFlagCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleRemoveBlockCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleRemoveGroupCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleRemoveParameterCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleRemoveHeightNodeCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleBlockListAddCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleBlockListRemoveCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleBlockListListCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleBlockListAddItemCommand(UnturnedPlayer player, string[] command)
        {
            
        }

        private void HandleBlockListRemoveItemCommand(UnturnedPlayer player, string[] command)
        {
            
        }
    }
}