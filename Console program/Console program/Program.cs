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
            Console.WriteLine("SetName - что бы ввести имя");
            Console.WriteLine("ChangeConsoleColor - что бы изменить цвет консоли");
            Console.WriteLine("SetNameColor - установить цвет имени");
            Console.WriteLine("ChangeName - изменить имя");
            Console.WriteLine("SetPassword - установить пароль");
            Console.WriteLine("Change Password - изменить пароль");
            Console.WriteLine("");
            Console.WriteLine("Esc - выйти из программы");
            Console.ReadKey();
        }
    }
}
