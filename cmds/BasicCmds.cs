using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kaitlyn.cmds
{
    public class BasicCmds : BaseCommandModule
    {

        // Hello Command
        [Command("hello")]
        [Description("Kaitlyn says Hi! <3")]
        public async Task Hello(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Hello there! I'm Kaitlyn. <3\nYou can find my commands using `k!help`.").ConfigureAwait(false);
        }

        // Add Command
        [Command("add")]
        [Description("Adds two numbers together.")]
        public async Task Add(CommandContext ctx, 
            [Description("Num. 1")] int one, 
            [Description("Num. 2")] int two)
        {
            await ctx.Channel.SendMessageAsync((one + two)
                .ToString())
                .ConfigureAwait(false);
        }

        // GetName Command
        [Command("getname")]
        [Description("Get a users name!")]
        public async Task Getname(CommandContext ctx, [Description("Member Input")] DiscordMember user)
        {
            string displayName = user.DisplayName;
            await ctx.Channel.SendMessageAsync(displayName).ConfigureAwait(false);
        }
    }
}
