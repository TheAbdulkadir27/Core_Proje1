namespace EntityLayer.Concrete
{
    public class Announcement
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime date { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
