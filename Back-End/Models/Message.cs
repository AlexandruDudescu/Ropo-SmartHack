using System;

class Message
{

    public Message(int id, string username, string message, DateTime messageTime)
    {
        this.MessageID = id;
        this.SenderUsername = username;
        this.MessageText = message;
        this.MessageTime = messageTime;
    }

    public int MessageID { get; set; }
    public string SenderUsername { get; set; }
    public string MessageText { get; set; }
    public DateTime MessageTime { get; set; }
}