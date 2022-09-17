using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal interface IWork
    {
        void Work();

    }
    interface IEat
    {
        void Eat();
    }
    interface IGetSalary
    {
        void GetSalary();
    }
    class Manager : IWork, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager eats");
        }

        public void GetSalary()
        {
            Console.WriteLine(" Manager gets salary");
        }

        public void Work()
        {
            Console.WriteLine(" Manager works");
        }
    }
    class Worker : IWork,IEat,IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("worker eats");
        }

        public void GetSalary()
        {
            Console.WriteLine(" worker gets salary");
        }

        public void Work()
        {
            Console.WriteLine(" worker works");
        }
    }
    class Robot : IWork
    {
        public void Work()
        {
            Console.WriteLine("robot works");
        }
    }
    class CustomerManager
    {
        public CustomerManager(IWork[] worker, IGetSalary[] salaries, IEat[] eats)
        {

            foreach (var func in worker)
            {
               
                func.Work();
               
            }
            foreach (var func in salaries)
            {

                func.GetSalary();

            }
            foreach (var func in eats)
            {

                func.Eat();

            }
        }
    }
}
