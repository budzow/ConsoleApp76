using System;

namespace AuthenticationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            bool isAuthenticated = program.Authenticate("username", "password");
            Console.WriteLine("Authentication " + (isAuthenticated ? "succeeded" : "failed"));
        }

        public bool isBypassPassword = false;

        public bool Authenticate(string username, string password)
        {
            // Example hardcoded credentials
            string correctUsername = "admin";
            string correctPassword = "admin123";

            if (isBypassPassword)
            {
                // Bypass password check
                return username == correctUsername;
            }
            else
            {
                // Perform full authentication
                return username == correctUsername && password == correctPassword;
            }
        }
    }
}