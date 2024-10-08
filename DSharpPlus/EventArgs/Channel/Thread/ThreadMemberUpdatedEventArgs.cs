using DSharpPlus.Entities;

namespace DSharpPlus.EventArgs;

/// <summary>
/// Represents arguments for ThreadMemberUpdated event.
/// </summary>
public class ThreadMemberUpdatedEventArgs : DiscordEventArgs
{
    /// <summary>
    /// Gets the thread member that was updated.
    /// </summary>
    public DiscordThreadChannelMember ThreadMember { get; internal set; }

    /// <summary>
    /// Gets the thread the current member was updated for.
    /// </summary>
    public DiscordThreadChannel Thread { get; internal set; }

    internal ThreadMemberUpdatedEventArgs() : base() { }
}
