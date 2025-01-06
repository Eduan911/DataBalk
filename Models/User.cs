namespace DataBalkCSharp.Models
{
    public class User
    {
        public int ID { get; set; }
        public string? Username { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? Password { get; set; } = string.Empty;
        public string? JwtKey { get; set; } = string.Empty; 
    }
}
