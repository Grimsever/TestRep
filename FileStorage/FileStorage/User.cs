namespace FileStorage
{
    public class User
    {
        private string Login { get; set; }

        private string Password { get; set; }

        public bool IsAuthenticated { get; private set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        
        public bool LogIn(string login, string password)
        {
            if (Login == login && Password == password)
            {
                IsAuthenticated = true;
                return IsAuthenticated;
            }

            return IsAuthenticated;
        }

        public override string ToString()
        {
            return $"Ow, login successful your data login is {Login} password is {Password}";
        }
    }
}
