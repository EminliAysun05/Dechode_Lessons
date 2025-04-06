using System.Collections;

namespace Generics
{
	internal class Program
	{
		static void Main(string[] args)
		{


			class DataStore<T>
		{
			private List<T> data = new List<T>();

			//public void Add(T item) => data.Add(item);

			public void Add(T item)
			{
				data.Add()
			}
			//public void Remove(T item) => data.Remove(item);
			//public void ShowAll()
			//{
			//	Console.WriteLine("Saxlanılan elementlər:");
			//	foreach (var item in data)
			//	{
			//		Console.WriteLine(item);
			//	}
			//}
		}


































		//Hashtable phoneBook = new Hashtable();

		//Console.WriteLine("Ad və telefon nömrələrini daxil edin:");
		//for (int i = 0; i < 3; i++)
		//{
		//	Console.Write("Ad: ");
		//	string name = Console.ReadLine();
		//	Console.Write("Telefon: ");
		//	string phone = Console.ReadLine();
		//	phoneBook[name] = phone;
		//}

		//Console.Write("\nAxtarmaq istədiyiniz adı daxil edin: ");
		//string searchName = Console.ReadLine();

		//if (phoneBook.ContainsKey(searchName))
		//{
		//	Console.WriteLine($"{searchName}-nın nömrəsi: {phoneBook[searchName]}");
		//}
		//else
		//{
		//	Console.WriteLine("Bu ad mövcud deyil.");
		//}


		//Stack browserHistory = new Stack();

		//browserHistory.Push("Facebook");
		//browserHistory.Push("YouTube");
		//browserHistory.Push("Google");

		//Console.WriteLine("Səhifələr:");
		//foreach (var page in browserHistory)
		//{
		//	Console.WriteLine(page);
		//}

		//Console.WriteLine("\nSon açılan səhifə: " + browserHistory.Pop());

		//Console.WriteLine("Qalan səhifələr:");
		//foreach (var page in browserHistory)
		//{
		//	Console.WriteLine(page);
		//}

	}
	}


}
