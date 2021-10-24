using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            var userServiceWithoutDIP = new withoutDIP.UserService();
            var userServiceWithDIP = new withDIP.UserService(new withDIP.UserRepository());
            Console.WriteLine("Hello World!");
        }
    }
}