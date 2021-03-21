using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;

namespace Token_Login_Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Concat(new string[]
            {
                Environment.NewLine,
                Environment.NewLine,
                Environment.NewLine,
                Environment.NewLine,
                Environment.NewLine,
                Environment.NewLine,
                Environment.NewLine,
                Environment.NewLine,
                Environment.NewLine,
                Environment.NewLine,
                Environment.NewLine
            }));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[");
            Console.ResetColor();
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("] ");
            Console.ResetColor();
            Console.Write("Token");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" : ");
            Console.ResetColor();
            string token = Console.ReadLine();

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://discord.com/login");

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            string login = (string)js.ExecuteScript("function login(token) {" +
                "setInterval(() => { " +
                "document.body.appendChild(document.createElement `iframe`).contentWindow.localStorage.token = `\"${token}\"`" +
                "}, 50);" +
                "setTimeout(() => {" +
                "location.reload();" +
                "}, 2500);" +
                "}" + $"login(\"{token}\")");
        }
    }
}
