using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAdviser
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("С помощью этой программы вы можете выбрать себе фильм на вечер.");
			Console.WriteLine("Как вас зовут?");
			string name = Console.ReadLine();

			Console.WriteLine("Приветствую, " + name);

			Console.WriteLine("Фильм какого жанра вы бы хотели посмотреть: комедия, хоррор, фантастика, эротика, триллер, боевик?");
			string genre = Console.ReadLine();


			if (genre == "комедия")
			{
				Console.WriteLine("Какой фильм вы предпочтете: отечественный или зарубежный?");
				string country = Console.ReadLine();
				if (country == "отечественный")
				{
					Console.ForegroundColor = ConsoleColor.DarkYellow;
					Console.WriteLine("В таком случае, рекомендую посмотреть вам следуюдие фильмы:");
					Console.WriteLine("* Иван Васильевич меняет профессию");
					Console.WriteLine("* Операция «Ы» и другие приключения Шурика");
					Console.WriteLine("* Бриллиантовая рука");
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.DarkYellow;
					Console.WriteLine("В таком случае, рекомендую посмотреть вам следуюдие фильмы:");
					Console.WriteLine("* Назад в будущее");
					Console.WriteLine("* Всегда говори «ДА»");
					Console.WriteLine("* Мачо и ботан");
				}
			}
			else if (genre == "фантастика")
			{
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("В таком случае, рекомендую посмотреть вам следуюдие фильмы:");
				Console.WriteLine("* Люди икс");
				Console.WriteLine("* Черепашки ниндзя");
				Console.WriteLine("* Дэдпул");
				Console.WriteLine("* Железный человек");

			}
			else if (genre == "триллер")
			{
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("В таком случае, рекомендую посмотреть вам следуюдие фильмы:");
				Console.WriteLine("* Начало");
				Console.WriteLine("* Бойцовский клуб");
				Console.WriteLine("* Форсаж 9");
				Console.WriteLine("* Хакер");
			}
			else if (genre == "боевик")
			{
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("В таком случае, рекомендую посмотреть вам следуюдие фильмы:");
				Console.WriteLine("* Темный рыцарь");
				Console.WriteLine("* Матрица");
				Console.WriteLine("* Веном");
				Console.WriteLine("* Никто");
			}
			else if (genre == "эротика")
			{
				Console.WriteLine("Сколько вам лет?");
				string yearString = Console.ReadLine();
				int years = Int32.Parse(yearString);
				if (years < 18)
				{
					Console.ForegroundColor = ConsoleColor.DarkYellow;
					Console.WriteLine("К сожалению, этот жанр доступен только для пользователей 18+");
					Console.WriteLine("Приходите через " + (18 - years) + " лет");
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.DarkYellow;
					Console.WriteLine("В таком случае, рекомендую посмотреть вам следуюдие фильмы:");
					Console.WriteLine("* Эммануэль");
					Console.WriteLine("* Нимфоманка");
					Console.WriteLine("* 50 оттенков серого");
					Console.WriteLine("* Взрослые игры");

				}
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("В таком случае, рекомендую посмотреть вам следуюдие фильмы:");
				Console.WriteLine("* Астрал");
				Console.WriteLine("* Пила");
				Console.WriteLine("* Синистер");
				Console.WriteLine("* Заклятие");

			}

			Console.ReadLine();
		}
	}
}
