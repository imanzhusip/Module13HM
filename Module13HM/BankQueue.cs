using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13HM
{
    public class BankQueue
    {
        private Queue<Client> clientsQueue = new Queue<Client>();
        public void Enqueue(Client client)
        {
            clientsQueue.Enqueue(client);
            Console.WriteLine($"{client.Name} встал в очередь за {client.ServiceType}.");
            DisplayQueue();
        }
        public void Dequeue()
        {
            if (clientsQueue.Count > 0)
            {
                Client servedClient = clientsQueue.Dequeue();
                Console.WriteLine($"Обслуживание {servedClient.Name} для {servedClient.ServiceType}.");
                DisplayQueue();
            }
            else
            {
                Console.WriteLine("В очереди нет клиентов.");
            }
        }

        private void DisplayQueue()
        {
            Console.Write("Текущая очередь: ");
            foreach (var client in clientsQueue)
            {
                Console.Write($"{client.Name}({client.ServiceType}) ");
            }
            Console.WriteLine();
        }
    }

}
