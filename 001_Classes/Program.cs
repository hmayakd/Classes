using System;


//Классы

namespace Classes
{
    // Создаем класс с именем MyClass.
    // В теле класса создаем открытое поле типа string с именем field и метод с именем Method.

    class MyClass
    {
        public string field;

        public void Method()
        {
            Console.WriteLine(field);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем экземпляр класса MyClass (по сильной ссылке).
            // 2. Создаем экземпляр класса MyClass с именем instance.
            // 3. Инстанцируем класс MyClass.

        }
    }
}
