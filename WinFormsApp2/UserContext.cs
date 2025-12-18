namespace WinFormsApp2
{
    public enum UserRole { Admin, Operator }

    public class UserContext
    {
        public int UserId { get; }
        public string Login { get; }
        public UserRole Role { get; }

        public UserContext(int userId, string login, UserRole role)
        {
            UserId = userId;
            Login = login;
            Role = role;
        }
    }
}
