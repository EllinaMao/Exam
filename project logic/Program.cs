using login_logic.interfaces;

namespace login_logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User admin = new RegularUser("admin" , "password123" , new DateOnly(1990 , 1 , 1));
            Console.WriteLine($"User Login: {admin.Login}");
            Console.WriteLine($"User Date of Birth: {admin.DateOfBirth}");
            bool isPasswordValid = admin.CheckPassword("password123");
            Console.WriteLine(isPasswordValid
            ? "Password is valid."
            : "Password is invalid.");
            Console.WriteLine(admin.GetType());


            //try
            //{

            //authService.Register("testUser" , "password123" , new DateOnly(1990 , 1 , 1));
            //authService.Register("newUser" , "newPassword" , new DateOnly(1995 , 5 , 15));
            //authService.Register("newUser" , "anotherPassword" , new DateOnly(1995 , 5 , 15)); // This should fail due to existing username
            //authService.Register("newUser2" , "anotherPassword" , new DateOnly(1995 , 5 , 15));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error during registration: {ex.Message}");
            //}


        }
    }
}
