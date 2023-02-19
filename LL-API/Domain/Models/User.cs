using Domain.Enums;

namespace Domain.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserStatus Status { get; set; }
        public IEnumerable<LanguageData> LearnInfo { get; set; }
    }
}
