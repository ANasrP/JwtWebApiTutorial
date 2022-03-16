namespace LoginAndAuthAPI
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty; 

        public Role Role { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        
    }
}
