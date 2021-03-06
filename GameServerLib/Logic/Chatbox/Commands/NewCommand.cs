﻿using ENet;
using static LeagueSandbox.GameServer.Logic.Chatbox.ChatCommandManager;

namespace LeagueSandbox.GameServer.Logic.Chatbox.Commands
{
    public class NewCommand : ChatCommandBase
    {
        public override string Command => "newcommand";
        public override string Syntax => $"{Command}";

        public NewCommand(ChatCommandManager chatCommandManager) : base(chatCommandManager)
        {
        }

        public override void Execute(Peer peer, bool hasReceivedArguments, string arguments = "")
        {
            var msg = $"The new command added by {ChatCommandManager.CommandStarterCharacter}help has been executed";
            ChatCommandManager.SendDebugMsgFormatted(DebugMsgType.INFO, msg);
            ChatCommandManager.RemoveCommand(Command);
        }
    }
}
