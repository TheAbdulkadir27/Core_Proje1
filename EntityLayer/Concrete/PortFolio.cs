using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class PortFolio
    {
        [Key]
        public int PortFolioID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string ProjectUrl { get; set; } = string.Empty;
        public string ImageUrl2 { get; set; } = string.Empty;

        public string Platform { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public bool Status { get; set; } = false;
        public string Image1 { get; set; } = string.Empty;
        public string Image2 { get; set; } = string.Empty;
        public string Image3 { get; set; } = string.Empty;
        public string Image4 { get; set; } = string.Empty;
        public int Value { get; set; }
    }
}
