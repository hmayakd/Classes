using System;

// Классы. (Использование свойств, для доступа к полям.)

// Свойство - интерфейс доступа к полю объекта.
// Свойства в C# - поля с логическим блоком, в котором есть ключевые слова get и set и являются суррогаом для замены методов доступа к полю.
// При общении к свойству вызывается определённый метод, который выполняет определённые операции с объектом.

namespace Classes
{
    class MyClass
    {
        private string field = null;

        public string Field
        {
            set
            {
                field = value;  // void SetField(string value)  -   Метод мутатор mutator (setter).
            }

            get
            {
                return field;   // string GetField()  -   Метод аксессор accessor (getter).
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.Field = "Hello world!";    // Метод мутатор.

            Console.WriteLine(instance.Field);  // Метод аксессор.

            // Delay
            Console.ReadLine();
        }
    }
}
