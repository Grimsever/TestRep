using System;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;


namespace FileStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            //todo переедет в метод, какого-нибудь класса, мб буду юзать DI контейнер, но это не точно
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            var appConfigValue = configuration.GetSection("user").GetChildren().ToArray();

            User user = new User(appConfigValue[0].Value, appConfigValue[1].Value);

            Console.WriteLine("Write login");
            string login = Console.ReadLine();
            Console.WriteLine("Write password");
            string password = Console.ReadLine();
            Console.WriteLine(user.LogIn(login,password)? "Ow, login successful":"Your data is`t correct");
        }
    }
}

