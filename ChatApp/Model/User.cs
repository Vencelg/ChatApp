using System;

namespace ChatApp.Model
{
    public class User(string username, string password, string email)
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = username;
        public string Password { get; set; } = password;
        public string Email { get; set; } = email;
        public List<ChatRoom> ChatRooms { get; set; } = [];
        public List<Message> Messages { get; set; } = [];
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
