using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Experiance
    {
        [Key]
        public int ExperianceID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
