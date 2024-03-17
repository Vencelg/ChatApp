namespace ChatApp.Definition.Request;

public record CreateMessageRequest(
    Guid ChatRoomId,
    string Text
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
    }
};