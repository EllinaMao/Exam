using login_logic;
using System.Text.Json;
namespace login_logic
{
    public class AuthService
    {
        private Dictionary<string , User> users;
        private const string FilePath = "users.json";

        public AuthService()
        {
            if (!File.Exists(FilePath))
                File.WriteAllText(FilePath , "[]"); // создаём пустой JSON массив при отсутствии файла
            users = new Dictionary<string , User>();
            LoadUsers();
        }

        // Регистрация обычного пользователя
        public bool Register(string login , string password , DateOnly birthDate)
        {
            if (users.ContainsKey(login))
            {
                Console.WriteLine($"Пользователь с логином {login} уже существует!");
                return false;
            }

            users[login] = new RegularUser(login , password , birthDate);
            SaveUsers();
            Console.WriteLine($"Пользователь {login} зарегистрирован.");
            return true;
        }


        public bool Login(string login , string password)
        {
            if (users.TryGetValue(login , out User? user))
            {
                if (user.CheckPassword(password))
                {
                    string role = "пользователь";
                    Console.WriteLine($"Добро пожаловать, {user.Login}! Вы вошли как {role}.");
                    return true;
                }
            }

            Console.WriteLine("Неверный логин или пароль.");
            return false;
        }
        // Сохранение пользователей в JSON
        public void SaveUsers()
        {
            try
            {
                var jsonUsers = new List<JsonUser>();
                foreach (var u in users.Values)
                {
                    jsonUsers.Add(new JsonUser
                    {
                        Login = u.Login ,
                        DateOfBirth = u.DateOfBirth ,
                        PasswordHash = u.GetPasswordHash() ,
                        Type = u.GetType().FullName ?? "login_logic.RegularUser"
                    });
                }

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                File.WriteAllText(FilePath , JsonSerializer.Serialize(jsonUsers , options));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении пользователей: {ex.Message}");
            }
        }

        // Загрузка пользователей из JSON
        public void LoadUsers()
        {
            try
            {
                if (!File.Exists(FilePath)) return;

                string json = File.ReadAllText(FilePath);
                if (string.IsNullOrWhiteSpace(json) || json.Trim() == "[]") return;

                var jsonUsers = JsonSerializer.Deserialize<List<JsonUser>>(json);
                if (jsonUsers == null) return;

                users.Clear();
                foreach (var j in jsonUsers)
                {
                    User user = new RegularUser(j.Login , "dummy" , j.DateOfBirth);
                    user.SetPasswordHash(j.PasswordHash);
                    users[user.Login] = user;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке пользователей: {ex.Message}");
            }
        }

        // Внутренний класс для сериализации
        private class JsonUser
        {
            public string Login { get; set; }
            public DateOnly DateOfBirth { get; set; }
            public string PasswordHash { get; set; }
            public string Type { get; set; } // Тип файла, для будущей возможности расширения функционала
        }
    }
}
