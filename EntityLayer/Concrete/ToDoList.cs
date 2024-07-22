using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class ToDoList
    {
        [Key]
        public int ID { get; set; }
        public string Content { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
