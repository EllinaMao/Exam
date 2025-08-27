using login_logic;
using System.Text.Json;
namespace login_logic
{
    public class AuthService
    {
        private Dictionary<string, User> users;
        private const string FilePath = "users.json";

        public AuthService()
        {
            try
            {
                if (!File.Exists(FilePath))
                    File.WriteAllText(FilePath, "[]");
                users = new Dictionary<string, User>();
                LoadUsers();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to initialize AuthService.", ex);
            }
        }

        // Регистрация обычного пользователя
        public void Register(string login, string password, DateOnly birthDate)
        {
            if (users.ContainsKey(login))
            {
                throw new ArgumentException($"User with login '{login}' already exists.");
            }

            users[login] = new RegularUser(login, password, birthDate);
            try
            {
                SaveUsers();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to save users after registration.", ex);
            }
        }

        public User Login(string login, string password)
        {
            if (!users.TryGetValue(login, out User? user))
            {
                throw new InvalidLoginOrPasswordException(login);
            }

            if (!user.CheckPassword(password))
            {
                throw new InvalidLoginOrPasswordException(login);
            }

            return user;
        }

        // Сохранение пользователей в JSON
        public void SaveUsers()
        {
            var jsonUsers = new List<JsonUser>();
            foreach (var u in users.Values)
            {
                jsonUsers.Add(new JsonUser
                {
                    Login = u.Login,
                    DateOfBirth = u.DateOfBirth,
                    PasswordHash = u.GetPasswordHash(),
                    Type = u.GetType().FullName ?? "login_logic.RegularUser"
                });
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            try
            {
                File.WriteAllText(FilePath, JsonSerializer.Serialize(jsonUsers, options));
            }
            catch (Exception ex)
            {
                throw new IOException("Error saving users to file.", ex);
            }
        }

        // Загрузка пользователей из JSON
        public void LoadUsers()
        {
            if (!File.Exists(FilePath))
                throw new FileNotFoundException("User data file not found.", FilePath);

            string json;
            try
            {
                json = File.ReadAllText(FilePath);
            }
            catch (Exception ex)
            {
                throw new IOException("Error reading user data file.", ex);
            }

            if (string.IsNullOrWhiteSpace(json) || json.Trim() == "[]")
                return;

            List<JsonUser>? jsonUsers;
            try
            {
                jsonUsers = JsonSerializer.Deserialize<List<JsonUser>>(json);
            }
            catch (Exception ex)
            {
                throw new JsonException("Error deserializing user data.", ex);
            }

            if (jsonUsers == null)
                throw new InvalidOperationException("User data is corrupted or empty.");

            users.Clear();
            foreach (var j in jsonUsers)
            {
                var user = new RegularUser(j.Login, "dummy", j.DateOfBirth);
                user.SetPasswordHash(j.PasswordHash);
                users[user.Login] = user;
            }
        }

        // Внутренний класс для сериализации
        private class JsonUser
        {
            public string Login { get; set; }
            public DateOnly DateOfBirth { get; set; }
            public string PasswordHash { get; set; }
            public string Type { get; set; }
        }
    }
}
