using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class AuthorMessage
    {
        [Key]
        public int ID { get; set; }
        public string Sender { get; set; } = string.Empty;
        public string Receiver { get; set; } = string.Empty;
        public string SenderName { get; set; } = string.Empty;
        public string ReceiverName { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string MessageContent { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
