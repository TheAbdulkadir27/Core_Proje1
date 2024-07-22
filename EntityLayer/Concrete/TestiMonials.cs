using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class TestiMonials
    {
        [Key]
        public int TestiMonialsID { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Comments { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
}
