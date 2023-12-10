using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13HM
{
    public class Program
    {
        static void Main()
        {
            BankQueue bankQueue = new BankQueue();

            while (true)
            {
                Console.WriteLine("1. Присоединится к очереди");
                Console.WriteLine("2. Обслужите следующего клиента");
                Console.WriteLine("3. Выход");

                Console.Write("Выберите вариант: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите свое имя: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите тип вашей услуги: ");
                        string serviceType = Console.ReadLine();
                        Client newClient = new Client(Guid.NewGuid().GetHashCode(), name, serviceType);
                        bankQueue.Enqueue(newClient);
                        break;

                    case "2":
                        bankQueue.Dequeue();
                        break;

                    case "3":
                        Console.WriteLine("Выход из программы.");
                        return;

                    default:
                        Console.WriteLine("Недопустимый параметр. Пожалуйста, попробуйте снова.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
