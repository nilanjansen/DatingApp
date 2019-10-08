using System;

namespace DatingApp.API.Dtos
{
    public class MessageForCreationDto
    {
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public DateTime MessageSentDate { get; set; }
        public String Content { get; set; }
        public MessageForCreationDto()
        {
            MessageSentDate = DateTime.Now;
        }
    }
}