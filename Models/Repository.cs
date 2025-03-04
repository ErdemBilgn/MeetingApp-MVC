namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Name = "Ali", Email = "abc@gmail.com", Phone = "1111", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Ahmet", Email = "abcd@gmail.com", Phone = "123111", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Helin", Email = "abce@gmail.com", Phone = "114111", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Arzu", Email = "abcf@gmail.com", Phone = "112311", WillAttend = false });
        }

        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}