using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            do
            {
                Console.WriteLine("UserName daxil edin:");
                username = Console.ReadLine();  
                
            } while (string.IsNullOrWhiteSpace(username) || username.Length<6 || username.Length>25);


            string password;
            do
            {
                Console.WriteLine("Password daxil edin:");
                password = Console.ReadLine();

            } while (!CheckPassword(password));

            User user = new User(username, password);

            Console.WriteLine($"UseName: {user.UserName} \nPassword: {user.Password}");
        }

        static bool CheckPassword(string password)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;

            if (!string.IsNullOrWhiteSpace(password) && password.Length > 7 && password.Length < 26)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsDigit(password[i]))
                        hasDigit = true;
                    else if (char.IsLower(password[i]))
                        hasLower = true;
                    else if (char.IsUpper(password[i]))
                        hasUpper = true;

                    if (hasUpper && hasLower && hasDigit)
                        return true;
                }
            }

            return false;
        }
    }
}
