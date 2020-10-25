using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class Stack<T> //Создаем новый класс Стек
    {
        /// Коллекция хранимых данных.
        private List<T> _items = new List<T>();
        /// Количество элементов.
        public int Count => _items.Count;
        /// Добавляем данные в стек.
        public void Push(T item)
        {
            // Проверяем входные данные на пустоту.
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            // Добавляем данные в коллекцию элементов.
            _items.Add(item);
        }
        /// Получить верхний элемент стека с удалением.
        public T Pop()
        {
            // Получаем верхний элемент.
            var item = _items.LastOrDefault();
            // Если элемент пуст, то сообщаем об ошибке.
            if (item == null)
            {
                throw new NullReferenceException("Стек пуст. Нет элементов для получения.");
            }
            // Удаляем последний элемент из коллекции.
            _items.RemoveAt(_items.Count - 1);  
            // Возвращаем полученный элемент.
            return item;
        }
        /// Прочитать верхний элемент стека без удаления.
        public T Peek()
        {
            // Получаем верхний элемент.
            var item = _items.LastOrDefault();
            // Если элемент пуст, то сообщаем об ошибке.
            if (item == null)
            {
                throw new NullReferenceException("Стек пуст. Нет элементов для получения.");
            }

            return item;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем новый стек.
            var stack = new Stack<int>();
            //Объявяем нужные нам переменные
            int n;
            // Добавляем новые элементы в стек.
            Console.Write($"Сколько элементов хотите внести ");
            n=Convert.ToInt16(Console.ReadLine());
            for (int i=0; i < n; i++)
            {
                Console.Write($"Элемент {i+1} = ");
                stack.Push(Convert.ToInt16(Console.ReadLine()));
            }
            Console.Write($"Стек содержит {stack.Count} элементов.");
            // Получаем элементы с удалением.
            var item1 = stack.Pop();
            Console.WriteLine($"Верхний элемент {item1}.");
            var item2 = stack.Pop();
            Console.WriteLine($"Предпоследний элемент {item2}.");
            // Получаем элемент без удаления.
            var item3 = stack.Peek();
            Console.WriteLine($"Новый верхний элемент {item3}.");
            var item4 = stack.Peek();
            Console.WriteLine($"Новый верхний элемент {item4}.");
            Console.ReadLine();
        }
    }
}
