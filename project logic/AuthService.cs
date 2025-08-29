using login_logic;
using System.Text.Json;

namespace login_logic
{
    public static class AuthService
    {
        private static Dictionary<string, User> users;
        private static readonly string FilePath = "users.json";

        // Статический конструктор для инициализации при первом обращении
        static AuthService()
        {
            users = new Dictionary<string, User>();
            try
            {
                if (!File.Exists(FilePath))
                {
                    // Создаём пустой файл, если его нет
                    File.WriteAllText(FilePath, "[]");
                }
                LoadUsers();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Ошибка инициализации AuthService.", ex);
            }
        }

        // Регистрация нового пользователя
        public static void Register(string login, string password, DateOnly birthDate)
        {
            if (users.ContainsKey(login))
                throw new ArgumentException($"Пользователь с логином '{login}' уже существует.");

            var user = new RegularUser(login, password, birthDate);
            users[login] = user;
            SaveUsers();
        }

        // Вход пользователя
        public static User Login(string login, string password)
        {
            if (!users.TryGetValue(login, out User? user))
                throw new InvalidLoginOrPasswordException(login);

            if (!user.CheckPassword(password))
                throw new InvalidLoginOrPasswordException(login);

            return user;
        }

        // Сохранение всех пользователей в JSON
        public static void SaveUsers()
        {
            var jsonUsers = users.Values.Select(u => new JsonUser
            {
                Login = u.Login,
                DateOfBirth = u.DateOfBirth,
                PasswordHash = u.GetPasswordHash(),
                Type = u.GetType().FullName ?? "login_logic.RegularUser"
            }).ToList();

            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(FilePath, JsonSerializer.Serialize(jsonUsers, options));
        }

        // Загрузка пользователей из JSON
        public static void LoadUsers()
        {
            if (!File.Exists(FilePath))
                return;

            string json = File.ReadAllText(FilePath);
            if (string.IsNullOrWhiteSpace(json) || json.Trim() == "[]")
                return;

            var jsonUsers = JsonSerializer.Deserialize<List<JsonUser>>(json);
            if (jsonUsers == null)
                return;

            users.Clear();
            foreach (var j in jsonUsers)
            {
                var user = new RegularUser(j.Login, "dummy", j.DateOfBirth);
                user.SetPasswordHash(j.PasswordHash);
                users[user.Login] = user;
            }
        }

        // Класс для сериализации пользователей
        private class JsonUser
        {
            public string Login { get; set; } = string.Empty;
            public DateOnly DateOfBirth { get; set; }
            public string PasswordHash { get; set; } = string.Empty;
            public string Type { get; set; } = "login_logic.RegularUser";
        }
    }
}
