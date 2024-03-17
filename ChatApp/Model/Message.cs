namespace ChatApp.Model;

public class Message(string text)
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ChatRoomId { get; set; }
    public Guid UserId { get; set; }
    public ChatRoom ChatRoom { get; set; }
    public User User { get; set; }
    public string Text { get; set; } = text;
    public DateTime Created { get; set; } = DateTime.Now;
}