using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Human
{
    public string name;
    public int age;
    public string gender;
    public Human(string name, int age, string gender)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
    }
    public void Eat()
    {
        Console.WriteLine("eating");
    }

    public void Sleep()
    {
        Console.WriteLine("sleeping");
    }
}

class Child : Human
{
    public string FavToy;
    public Child(string name, int age, string gender, string favToy)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.FavToy = favToy;
    }

    public void Set(string toys)
    {
        FavToy = toys;
        Console.WriteLine();
    }
}
