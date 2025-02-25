using System.Runtime.InteropServices;

namespace Records__Deconstructor__Inhertance_and_others
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Init Only Properties
			//var person = new Person
			//{
			//	FullName = "John Doe",
			//	Age = 30
			//};

			//// Bu kod xətaya səbəb olacaq, çünki `init` propertilər obyekt yaradıldıqdan sonra dəyişdirilə bilməz:
			//person.FullName = "Jane Doe"; // ❌ Compiler error
			//Burada FullName və Age obyekt yaradılarkən təyin edilir, lakin sonradan dəyişdirilə bilmir.
			#endregion

			#region Readonly Properties
			//var person = new Person("John Doe", 30);

			//Console.WriteLine(person.FullName); // ✅ "John Doe"

			//// Xəta! `readonly` dəyəri obyekt yaradıldıqdan sonra dəyişmək olmur
			////person.FullName = "Jane Doe"; // ❌ Compiler error
			//🟢 Burada FullName və Age sahələri yalnız constructor daxilində təyin edilə bilər.

			#endregion

			#region Records

			//record
			//var person1 = new Person("John Doe", 30);
			//var person2 = new Person("John Doe", 30);
			//Console.WriteLine(person1 == person2); // ✅ True (dəyərlər müqayisə olunur)
			//Console.WriteLine(person1); // ✅ "Person { FullName = John Doe, Age = 30 }"


			////class
			//var person = new Person1("John Doe", 30);
			//var person0 = new Person1("John Doe", 30);
			//Console.WriteLine(person == person0);


			//WITH ILE KOPYALAMA
			//var person = new Person("Alice", 25);
			//var updatedPerson = person with { Age = 26 };

			//Console.WriteLine(person);        // Person { FullName = Alice, Age = 25 }
			//Console.WriteLine(updatedPerson); // Person { FullName = Alice, Age = 26 }
			//Console.WriteLine(person);



			#endregion

			#region Ctor temalari
			//var person1 = new Person();
			// Çıxış: Default constructor is called!
			// person1.FullName -> "Unknown"
			// person1.Age -> 18
			#endregion

			#region Ctor temalari2
			//var car1 = new Car();
			//car1.DisplayInfo();// Çıxış: Brand: Unknown, Model: Unknown, Year: 2024

			//var car2 = new Car("Toyota");
			//car2.DisplayInfo(); // Çıxış: Brand: Toyota, Model: Unknown, Year: 2024

			//var car3 = new Car("BMW", "X5", 2026);
			//car3.DisplayInfo(); // Çıxış: Brand: BMW, Model: X5, Year: 2024

			//var car4 = new Car("Mercedes", "C-Class", 2022);
			//car4.DisplayInfo(); // Çıxış: Brand: Mercedes, Model: C-Class, Year: 2022
			#endregion

			#region Deconstructor methodu
			//Person person = new Person("Ali", 25);

			//// Deconstruct metodu avtomatik işləyir
			//(string name, int age) = person;

			//Console.WriteLine($"Ad: {name}, Yaş: {age}");
           
			#endregion
		}

		#region Init only properties

		//public class Person
		//{
		//	public string FullName { get; init; }  // `init` yalnız obyekt yaradılarkən dəyər təyin etməyə icazə verir
		//	public int Age { get; init; }
		//          public int MyProperty { get; set; }//prop property
		//      }

		#endregion

		#region Readonly properties
		//public class Person
		//{
		//	public readonly string FullName; // Field
		//	public readonly int Age;

		//          public Person(string fullName, int age)
		//	{
		//		FullName = fullName; // Dəyəri yalnız burada təyin etmək olar
		//		Age = age;
		//	}
		//}

		#endregion

		#region Records
		//public record Person
		//{
		//	public string FullName { get; init; }
		//	public int Age { get; init; }

		//	public Person(string fullName, int age)
		//	{
		//		FullName = fullName;
		//		Age = age;
		//	}
		//}

		////Record qisa yazilis
		//public record Person(string FullName, int Age);

		//public class Person1
		//{
		//	public string FullName { get; init; }
		//	public int Age { get; init; }

		//	public Person1(string fullName, int age)
		//	{
		//		FullName = fullName;
		//		Age = age;
		//	}
		//}



		#endregion

		#region Ctor temalari

		//public class Person
		//{
		//	public string FullName { get; set; }
		//	public int Age { get; set; }

		//	//ctor + tab

		//	// Əsas konstruktor
		//	public Person(string fullName, int age)
		//	{
		//		FullName = fullName;
		//		Age = age;
		//	}

		//          // Default konstruktor
		//          public Person() : this("Unknown", 18) // Burada əsas konstruktor çağırılır
		//	{
		//		Console.WriteLine("Default constructor is called!");
		//	}
		//}




		#endregion

		#region Ctor temalari2 ---Coxlu ctor cagirmaq
		//public class Car
		//{
		//	public string Brand { get; set; }
		//	public string Model { get; set; }
		//	public int Year { get; set; }

		//	// Əsas konstruktor
		//	public Car(string brand, string model, int year)
		//	{
		//		Brand = brand;
		//		Model = model;
		//		Year = year;
		//	}

		//	// 2 parametrli konstruktor -> əsas konstruktora yönləndirir
		//	public Car(string brand, string model) : this(brand, model, 2024) { }

		//	// 1 parametrli konstruktor -> 2 parametrli konstruktora yönləndirir
		//	public Car(string brand) : this(brand, "Unknown") { }

		//	// Default konstruktor -> 1 parametrli konstruktora yönləndirir
		//	public Car() : this("Unknown") { }

		//	// 🔹 Obyektin məlumatlarını ekrana çıxaran metod
		//	public void DisplayInfo()
		//	{
		//		Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
		//	}
		//}
		#endregion region

		#region Deconstruct Methodu
		//public class Person
		//{
		//	public string Name { get; }
		//	public int Age { get; }

		//	public Person(string name, int age)
		//	{
		//		Name = name;
		//		Age = age;
		//	}

		//	// Deconstruct metodu
		//	public void Deconstruct(out string name, out int age)
		//	{
		//		name = Name;
		//		age = Age;
		//	}
		//}

		#endregion

		//public int Age { get; set; }

	}
}
