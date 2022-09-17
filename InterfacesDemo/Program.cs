// See https://aka.ms/new-console-template for more information
using InterfacesDemo;

Console.WriteLine("Hello, World!");
IWork[] workers = new IWork[]
{
                new Worker(),
                new Manager(),
                new Robot()
};
IEat[] eaters = new IEat[]
{
    new Worker(),
    new Manager()
};
IGetSalary[] salaries = new IGetSalary[]
{
    new Worker(),
    new Manager()

};
CustomerManager customer = new CustomerManager(workers,salaries,eaters);
