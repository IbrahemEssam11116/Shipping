namespace Shiping.Services.Models.Auth
{
    public class UserDataForToken
    {
        public int UserId { get; set; }
        public bool IsAdmin { get; set; }
        public string UserName { get; set; }
        public int UserType { get; set; }
        public string UserTypeName { get; set; }
        public List<string> Permissions { get; set; } = new List<string>();
    }
}
