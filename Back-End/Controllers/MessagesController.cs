using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
class MessagesController : Controller
{
    private readonly UserContext _context;

    public MessagesController(UserContext context)
    {
        _context = context;

        if(_context.Messages.Count() == 0)
        {
            AddMessage(new Message(1, "Alex", "Hello", DateTime.Now));
            AddMessage(new Message(2, "Robert","Hai sa facem o aplicatie <3", DateTime.Now));
        }
    }

    //Get all messages
    [HttpGet]
    public List<Message> GetAllMessages()
    {
        return _context.Messages.ToList();
    }
    //Get last x messages
    //Add message
    [HttpPost]
    public void AddMessage(Message message)
    {
        _context.Messages.Add(message);
        _context.SaveChanges();
    }
}