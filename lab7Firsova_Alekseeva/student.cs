using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab7Firsova_Alekseeva
{
    internal class student
    {
        public string name;
        public int age;
        public string group;
        public student()
        {
            Console.WriteLine("Создание объекта Студент");
            name = "Неизвестно";
            age = 18;
            group = "Неизвестно";
        }
        // 2. Конструктор с 1 параметром имя
        
public student(string yorName) { this.name = yorName; this.age = 18; this.group ="Неизвестно"; }
        // 3. Конструктор с 2 параметрами имя и возраст
        
public student(string yorName, int yourAge) { this.name = yorName; this.age = yourAge; this.group = "Неизвестно"; }
        // 4. Полный конструктор с 3 параметрами имя, возраст и группа.
public student(string yorName, int yourAge, string yourGroup) { this.name =yorName; this.age = yourAge; this.group = yourGroup; }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {name}, возраст: {age}, Группа: {group}");

        }
        public bool IsAdult()
        {
            return age >= 18;
        }
    }
}
