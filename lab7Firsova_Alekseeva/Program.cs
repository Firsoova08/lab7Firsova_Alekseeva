using System.Numerics;

namespace lab7Firsova_Alekseeva
{
   class Program
   {
        static void Main(string[] args)
        {
                Console.WriteLine("Hello,world!");
                Student denis = new Student();
                Console.WriteLine(denis);
                denis.name = "Denis";
                denis.age = 18;
                denis.group = "ISP-231";
                denis.PrintInfo();
                Console.WriteLine($"Студент {denis.name} совершеннолетний - {denis.IsAdult()}");
            Student anton = new();
            anton.PrintInfo();
            Console.ReadLine();
                Player player = new Player();
                player.TakeDamage(34);
                Console.WriteLine(player.GetHealth());
                player.health = 1000;

                Television tv = new Television();
                tv.SetVolume(50);
                tv.SetVolume(150);

                BankAccount bankAccount = new BankAccount();
                bankAccount.Deposit(50);
                bankAccount.Withdraw(23);

        }
   }
        class Student
        {
            public string name;
            public int age;
            public string group;

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
    

