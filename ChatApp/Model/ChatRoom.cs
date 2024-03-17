using System;
using System.Collections.Generic;

namespace ChatApp.Model
{
    public class ChatRoom(string name)
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = name;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<User> Users { get; set; }
        public List<Message> Messages { get; set; }
    }
}
