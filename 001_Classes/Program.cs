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
            // 1. Create an instance of class MyClass with strong reference
            // 2. Создаем экземпляр класса MyClass с именем instance.
            // 3. Инстанцируем класс MyClass.
            // 4. Создаем переменную с именем instance, типа MyClass и присваиваем ей адрес экземпляра на куче.
            // (instance - является ссылкой на экземпляр класса MyClass построенный на куче)

            MyClass instance = new MyClass(); // это сильная ссылка //this is a strong reference
            
            // new MyClass().Method(); // это слабая ссылка... одноразовая  // this is a weak reference

            // Полю field, экземпляра instance, присваиваем значение Hello world!
            // To field field of a instance instance, assign value Hello world!
            instance.field = "Hello world!";

            // Выводим на экран значение поля field экземпляра instance.

            Console.WriteLine(instance.field);

            // Вызов метода с именем Method на экземпляре instance.
            instance.Method();

            // Delay
            Console.ReadLine();
        }
    }
}
