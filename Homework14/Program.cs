using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> queue = new Queue<string>();
            // добавление элементов
            queue.AddToEnd("Саша");
            queue.AddToEnd("Маша");
            queue.AddToEnd("Даша");
            queue.AddToEnd("Глаша");

            // выводим элементы
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // удаляем элемент
            queue.Delete("Маша");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Delete \"Маша\"");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // проверяем наличие элемента
            bool isPresent = queue.Contains("Дима");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("проверяем наличие элемента \"Дима\"");
            Console.WriteLine(isPresent == true ? "Дима присутствует" : "Sam отсутствует");

            // проверяем наличие элемента
            isPresent = queue.Contains("Глаша");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("проверяем наличие элемента \"Глаша\"");
            Console.WriteLine(isPresent == true ? "Глаша присутствует" : "Sam отсутствует");

            // добавляем элемент в начало            
            queue.AddToStart("Сергей");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("добавляем элемент в начало  \"Сергей\"");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // добавляем элемент в конец            
            queue.AddToEnd("Яна");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("добавляем элемент в конец  \"Яна\"");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // добавляем элемент в индекс 3            
            queue.AddByIndex("Миша", 3);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("добавляем элемент в индекс 3  \"Миша\"");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // получаем 3 элемент
            //isPresent = linkedList.Contains("Bill!!!!");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("получаем 3 элемент");
            Console.WriteLine(queue[3].Data);



            Console.ReadKey();
        }
    }
}
