using BCrypt.Net;
using login_logic.interfaces;
using System.Text.Json.Serialization;
/*
*BCrypt — это алгоритм хэширования паролей, специально придуманный для безопасности.
Почему не SHA256 или Base64:
SHA256 и подобные функции очень быстрые.Можно за секунду перебрать миллионы паролей.
BCrypt специально сделан медленным, чтобы перебор занимал больше времени.
Он добавляет соль (случайные данные), чтобы одинаковые пароли у разных людей имели разные хэши.*/

/*Задание 2
 * 
 * Создать приложение «Викторина».
 * Основная задача проекта: предоставить пользователю возможность проверить свои знания в разных областях.Интерфейс приложения должен предоставлять такие возможности:
 * ■ При старте приложения пользователь вводит логин и пароль для входа. Если пользователь не зарегистрирован, он должен пройти процесс регистрации.
 * ■ При регистрации нужно указать:
 * • логин (нельзя зарегистрировать уже существующий логин);
 * • пароль;
 * • дату рождения.
 * 
 * */
namespace login_logic
{
    public class User : ILogin, ICriptedPassword
    {
        [JsonPropertyName("Логин")]
        public string Login { get; private set; }
        [JsonPropertyName("Дата рождения")]
        public DateOnly DateOfBirth { get; private set; }
        [JsonPropertyName("Хэш пароля")]
        private string passwordHash;

        public User() {
            // Пустой конструктор для сериализации в JSON
            Login = string.Empty;
            DateOfBirth = DateOnly.MinValue;
            passwordHash = string.Empty;
        } 

        public User(string login , string password , DateOnly dateOfBirth)
        {
            Login = login;
            DateOfBirth = dateOfBirth;
            passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool CheckPassword(string password)
        {
            return BCrypt.Net.BCrypt.Verify(password , passwordHash);
        }

        // Для восстановления из JSON (с готовым хэшем)
        public void SetPasswordHash(string hash)
        {
            passwordHash = hash;
        }
        public string GetPasswordHash()
        {
            return passwordHash;
        }

    }
}
