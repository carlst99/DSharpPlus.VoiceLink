namespace DSharpPlus.VoiceLink.Payloads
{
    public sealed record VoiceUserJoinPayload
    {
        public required ulong UserId { get; init; }
    }
}
