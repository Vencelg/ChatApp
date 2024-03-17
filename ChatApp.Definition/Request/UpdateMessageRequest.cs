namespace ChatApp.Definition.Request;

public record UpdateMessageRequest(
    Guid ChatRoomId,
    string Text,
    DateTime SentAt
) : IRequest
{
    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(Text))
        {
            throw new ArgumentNullException(nameof(Text));
        }

        if (ChatRoomId == Guid.Empty)
        {
            throw new ArgumentNullException(nameof(ChatRoomId));
        }

        if (SentAt > DateTime.Now)
        {
            throw new ArgumentException("SentAt cannot be in the future");
        }
    }
}