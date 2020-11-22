using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string name = "name";
            int password = 0;
            while (exit == false) 
            {
                if (name == "name")
                {
                    Console.WriteLine("SetName - что бы ввести имя");
                }
                else
                {
                    Console.WriteLine("имя установлено");
                }
                Console.WriteLine("ChangeConsoleColor - что бы изменить цвет консоли");
                Console.WriteLine("ChangeTextColor - установить цвет текста");
                if (password == 0)
                {
                    Console.WriteLine("SetPassword - установить пароль");
                }
                else
                {
                    Console.WriteLine("пароль установлен");
                }
                Console.WriteLine("WriteName - вывести имя");
                Console.WriteLine("Esc - выйти из программы");

                switch (Console.ReadLine())
                {
                    case "SetName":
                        Console.WriteLine("Введите имя:");
                        name = Console.ReadLine();
                        break;
                    case "ChangeConsoleColor":
                        Console.WriteLine("Выберете цвет:");
                        Console.WriteLine("black, green, blue, red, yellow, white");
                        switch (Console.ReadLine())
                        {
                            case "black":
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;
                            case "green":
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            case "blue":
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                            case "red":
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            case "yellow":
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                            case "white":
                                Console.BackgroundColor = ConsoleColor.White;
                                break;
                        }
                        break;
                    case "ChangeTextColor":
                        Console.WriteLine("Выберете цвет:");
                        Console.WriteLine("black, green, blue, red, yellow, white");
                        switch (Console.ReadLine())
                        {
                            case "black":
                                Console.ForegroundColor = ConsoleColor.Black;
                                break;
                            case "green":
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case "blue":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case "red":
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case "yellow":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            case "white":
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                        break;
                    case "SetPassword":
                        Console.WriteLine("Введите желаемый пароль:");
                        password = Convert.ToInt32(Console.ReadLine());
                        break; 
                    case "WriteName":
                        int userInput;
                        int inputAttempts = 3;
                        if (password != 0)
                        {
                            while (inputAttempts-- > 0)
                            {
                                Console.WriteLine("Для ввывода имени введите пароль:");
                                userInput = Convert.ToInt32(Console.ReadLine());
                                if (userInput == password)
                                {
                                    Console.WriteLine(name);
                                }
                                else
                                {
                                    Console.WriteLine("У вас осталось " + inputAttempts + " попыток.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(name);
                        }
                        break;
                    case "Esc":
                        exit = true;
                        break;
                }
                Console.Clear();
            }
        }
    }
}
