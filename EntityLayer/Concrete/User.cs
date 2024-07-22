using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class User : IdentityUser<int> , IDisposable
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string imageUrl { get; set; } = string.Empty;
        public bool Status { get; set; }
        public IEnumerable<UserMessage> UserMessage { get; set; }
        public void Dispose() => GC.SuppressFinalize(this);
    }
}
