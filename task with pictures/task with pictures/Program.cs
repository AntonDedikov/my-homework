using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_with_pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int userPictures = 52;
            int seriesPictures = userPictures / 3;
            int lostPictures = userPictures % 3;

            Console.WriteLine("Количество заполненных рядов: " + seriesPictures);
            Console.WriteLine("Сверх меры: " + lostPictures);
            Console.ReadKey();
        }
    }
}
