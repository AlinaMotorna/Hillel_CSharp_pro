using System;
using System.Threading;

namespace SleepingBarber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Random Rand = new Random();
            const int MaxCustomers = 10;
            const int NumChairs = 3;
            Semaphore waitingRoom = new Semaphore(NumChairs, NumChairs);
            Semaphore barberChair = new Semaphore(1, 1);
            Semaphore barberSleepChair = new Semaphore(0, 1);
            Semaphore seatBelt = new Semaphore(0, 1);
            bool AllDone = false;
            void Barber()
            {
                while (!AllDone)
                {
                    Console.WriteLine("Барбер спить.");
                    barberSleepChair.WaitOne();
                    if (!AllDone)
                    {
                        Console.WriteLine("Барбер стриже");
                        Thread.Sleep(Rand.Next(1, 3) * 1000);
                        Console.WriteLine("Барбер постриг");
                        seatBelt.Release();
                    }
                    else
                    {
                        Console.WriteLine("Барбер спить.");
                    }
                }
                return;
            }
            void Customer(Object number)
            {
                int Number = (int)number;
                Console.WriteLine("Клієнт {0} йде в барбершоп...", Number);
                Thread.Sleep(Rand.Next(1, 5) * 1000);
                Console.WriteLine("Клієнт {0} прийшов!", Number);
                waitingRoom.WaitOne();
                Console.WriteLine("Клієнт {0} заходить в кімнату очікування", Number);
                barberChair.WaitOne();
                waitingRoom.Release();
                Console.WriteLine("Клієнт {0} будить барбера...", Number);
                barberSleepChair.Release();
                seatBelt.WaitOne();
                barberChair.Release();
                Console.WriteLine("Клієнт {0} покидає барбершоп", Number);
            }
            Thread BarberThread = new Thread(Barber);
            BarberThread.Start();
            Thread[] Customers = new Thread[MaxCustomers];
            for (int i = 0; i < MaxCustomers; i++)
            {
                Customers[i] = new Thread(new ParameterizedThreadStart(Customer));
                Customers[i].Start(i);
            }
            for (int i = 0; i < MaxCustomers; i++)
            {
                Customers[i].Join();
            }
            AllDone = true;
            barberSleepChair.Release();
            BarberThread.Join();
            Console.WriteLine("Кінець робочого дня!");
            Console.ReadKey();
        }
    }
}
