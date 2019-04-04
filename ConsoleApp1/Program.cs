using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Human
    {
		#region Задача перемен имени и возраста (Свойства объекта)
		public int Age { get; private set; }
		public string Name { get; private set; }
		#endregion

		#region Создание конструктора объекта
		public Human(int Age, string Name)
		{
			this.Age = Age;
			this.Name = Name;
			Console.WriteLine("Я появился, меня зовут " + this.Name);
		}
		#endregion

		#region Методы класса
		public void HeppyB()
		{
			Age++;
			Console.WriteLine("У меня день пождения, мне исполнилось " + Age);
		}

		public void SayName()
		{
			Console.WriteLine("Меня зовут " + Name);
		}

		public void SayAge()
		{
			Console.WriteLine("Мне " + Age);
		}
		#endregion

		~Human()
		{
			Console.WriteLine("Обект был удален");
		}
	}
	class Program
    {
        static void Main(string[] args)
        {
			Human Vasya = new Human(20, "Вася");
			Vasya.SayName();
			Vasya.SayAge();
			Vasya.HeppyB();
			Console.ReadLine();
        }
    }
}
