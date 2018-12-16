using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection {
    class Program {
        static void Main(string[] args) {
            Circle obj = new Circle(2.4);
            Type t = obj.GetType();
            Console.WriteLine("Рефлексия.\n\nИнформация о типе: ");
            Console.WriteLine($"Пространство имён {t.Namespace}\nИмя: {t.FullName}\nСборка: {t.AssemblyQualifiedName}");
            Console.WriteLine("\nКонструкторы:");
            foreach (var x in t.GetConstructors()) {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nПоля:");
            foreach (var x in t.GetFields()) {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nСвойства:");
            foreach (var x in t.GetProperties()) {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods()) {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nСвойства с атрибутами:");
            foreach (var x in t.GetProperties()) {
                if (x.GetCustomAttributes(typeof(PropAttr), false).Length > 0) {
                    Console.WriteLine(x + " " + PropAttr.Description);
                }
            }
            Console.ReadLine();
            Attribute[] attrs = Attribute.GetCustomAttributes(t);
        }
    }
}
