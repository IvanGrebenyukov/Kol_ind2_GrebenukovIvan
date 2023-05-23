using System;
using System.Collections.Generic;
using System.Collections;
namespace Zadanie4
{
	class Program
	{
		static Hashtable catalog = new Hashtable();

		static void Main(string[] args)
		{
			bool check = false;

			while (!check)
			{

				Console.WriteLine("Выберите действие:\n" +
								  "1. Добавить новый диск\n" +
								  "2. Удалить диск\n" +
								  "3. Добавить песню на диск\n" +
								  "4. Удалить песню с диска\n" +
								  "5. Просмотреть каталог\n" +
								  "6. Просмотреть содержимое диска\n" +
								  "7. Поиск всех записей определенного исполнителя\n" +
								  "8. Выход");

				string choise = Console.ReadLine();

				switch (choise)
				{
					case "1": AddDisk(); break;
					case "2": DeleteDisk(); break;
					case "3": AddSong(); break;
					case "4": DeleteSong(); break;
					case "5": DisplayCatalog(); break;
					case "6": DisplayDisk(); break;
					case "7": SearchByArtist(); break;
					case "8": check = true; break;
					default:
					{
						Console.WriteLine("Ошибка! Повторите ввод!");
					}
					break;
				}
			}
		}
		private static void AddDisk()
		{
			Console.Clear();
			Console.Write("Введите название диска: ");
			string nameDisk = Console.ReadLine();

			if (catalog.ContainsKey(nameDisk))
			{
				Console.WriteLine("Такой диск уже существует");
			}
			else
			{
				catalog[nameDisk] = new ArrayList();
				Console.WriteLine("Диск был добавлен");
			}
		}
		private static void DeleteDisk()
		{
			Console.Clear();
			if (catalog.Count == 0)
			{
				Console.WriteLine("Данный каталог пуст");
			}
			else
			{
				Console.Write("Введите название диска: ");
				string nameDisk = Console.ReadLine();

				if (catalog.ContainsKey(nameDisk))
				{
					catalog.Remove(nameDisk);
					Console.WriteLine("Диск был удален");
				}
				else
				{
					Console.WriteLine("Такого диска не существует");
				}
			}
		}
		private static void AddSong()
		{
			Console.Clear();
			Console.Write("Введите название диска: ");
			string nameDisk = Console.ReadLine();

			if (catalog.ContainsKey(nameDisk))
			{
				ArrayList songs = (ArrayList)catalog[nameDisk];

				Console.Write("Введите название песни: ");
				string nameSong = Console.ReadLine();
				Console.Write("Введите имя исполнителя: ");
				string nameArtist = Console.ReadLine();

				if (songs.Contains(nameSong))
				{
					Console.WriteLine("Такая песня уже есть на этом диске.");
				}
				else
				{
					songs.Add(string.Concat(nameSong, " ", nameArtist));
					Console.WriteLine("Песня была добавлена");
				}
			}
			else
			{
				Console.WriteLine("Такого диска не существует");
			}
		}
		private static void DeleteSong()
		{
			Console.Clear();
			if (catalog.Count == 0)
			{
				Console.WriteLine("Данный каталог пуст");
			}
			else
			{
				Console.Write("Введите название диска: ");
				string nameDisk = Console.ReadLine();

				if (catalog.Contains(nameDisk))
				{
					ArrayList songs = (ArrayList)catalog[nameDisk];

					if (songs.Count == 0)
					{
						Console.WriteLine($"Диск {nameDisk} пуст");
					}
					else
					{
						Console.Write("Введите название песни: ");
						string nameSong = Console.ReadLine();

						if (songs.Contains(nameSong))
						{
							songs.Remove(nameSong);
							Console.WriteLine("Песня была удалена");
						}
						else
						{
							Console.WriteLine($"Такая песня не существует на диске {nameDisk}.");
						}
					}
				}
				else
				{
					Console.WriteLine("Такого диска не существует");
				}
			}
		}
		private static void DisplayDisk()
		{
			Console.Clear();
			if (catalog.Count == 0)
			{
				Console.WriteLine("Данный каталог пуст");
			}
			else
			{
				Console.Write("Введите название диска: ");
				string nameDisk = Console.ReadLine();

				if (catalog.ContainsKey(nameDisk))
				{
					ArrayList songs = (ArrayList)catalog[nameDisk];

					if (songs.Count == 0)
					{
						Console.WriteLine($"Диск {nameDisk} пуст");
					}
					else
					{
						Console.WriteLine($"Содержимое диска {nameDisk}: ");

						int i = 1;
						foreach (string nameSong in songs) 
						{ 
							Console.WriteLine($"{i}: {nameSong}"); i++; 
						}
					}
				}
				else
				{
					Console.WriteLine("Такого диска не существует");
				}
			}
		}
		private static void DisplayCatalog()
		{
			Console.Clear();

			if (catalog.Keys.Count == 0)
			{
				Console.WriteLine("Данный каталог пуст");
			}
			else
			{
				Console.WriteLine("Содержимое каталога:");

				int i = 1;
				foreach (string nameDisk in catalog.Keys) 
				{ 
					Console.WriteLine($"{i}: {nameDisk}"); i++; 
				}
			}
		}

		

		
		private static void SearchByArtist()
		{
			Console.Clear();
			if (catalog.Count == 0)
			{
				Console.WriteLine("Данный каталог пуст");
			}
			else
			{
				Console.Write("Введите имя исполнителя: ");
				string nameArtist = Console.ReadLine();
				bool found = false;
				int i = 0;

				foreach (ArrayList songs in catalog.Values)
				{

					foreach (string nameSong in songs)
					{
						if (nameSong.Contains(nameArtist))
						{
							Console.WriteLine($"{nameSong}");
							found = true; i++;
						}
					}
				}

				if (!found)
				{
					Console.WriteLine("Записи исполнителя не найдены");
				}
				else
				{
					Console.WriteLine($"Найдены записи в количестве: {i}");
				}
			}
		}




	}

}


