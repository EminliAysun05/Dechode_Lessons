using System;
using System.Security.Cryptography;
using static System.Formats.Asn1.AsnWriter;

namespace LINQ
{
	public class Program
	{
		static void Main(string[] args)
		{
			#region Deferred Execution example
			var products = new List<Product>
			{
				new Product { Id = 1, Name="apple"},
				new Product { Id = 2, Name="banana"},
				new Product { Id = 3, Name="cherry"},
				new Product { Id = 4, Name="strawberry"},
				new Product { Id = 5, Name="berry"}
			};

			//var product = products.Where(p => p.Id == 3).ToList();
			//product.Add(new Product { Id = 6, Name = "kiwi" });
			//foreach (var item in product)
			//{
			//	Console.WriteLine(item.Name);
			//}
			var product = products.Where(p => p.Id == 3); // Deferred Execution aktivdir
			products.Add(new Product { Id = 3, Name = "kiwi" });

			foreach (var p in product)
				Console.WriteLine(p.Name);
			#endregion
			#region LINQ
			////WHERE
			//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

			//var evenNumbers = numbers.Where(n => n % 2 == 0);

			//foreach (var n in evenNumbers)
			//	Console.WriteLine(n); // 2, 4, 6

			////SELECT	
			//var names = new List<string> { "Aysun", "Veysal", "Elvin" };

			//var nameLengths = names.Select(n => new { Name = n, Length = n.Length });

			//foreach (var item in nameLengths)
			//	Console.WriteLine($"{item.Name} -> {item.Length}");


			////ORDER BY
			//var sortedNames = names.OrderBy(n => n);

			//foreach (var name in sortedNames)
			//	Console.WriteLine(name); // Aysun, Elvin, Veysal


			////GROUP BY
			//var students = new List<Student>
			//         {
			//	new Student { Name = "Aysun", Group = "A" },
			//	new Student { Name = "Veysal", Group = "B" },
			//	new Student { Name = "Elvin", Group = "A" }
			//};

			//var grouped = students.GroupBy(s => s.Group);

			//foreach (var group in grouped)
			//{
			//	Console.WriteLine("Group: " + group.Key);
			//	foreach (var student in group)
			//		Console.WriteLine(" - " + student.Name);
			//}

			////SUM AVERAGE COUNT
			//var salaries = new List<int> { 1000, 1200, 900, 1100 };

			//int total = salaries.Sum();           // 4200
			//double average = salaries.Average();  // 1050
			//int count = salaries.Count();         // 4

			////JOIN
			//		var students1 = new List<Student>
			//		{ 
			//new Student { Id = 1, Name = "Aysun" },
			//new Student { Id = 2, Name = "Veysal" }
			//		};
			//var scores = new List<Score>
			//		{
			//new Score { StudentId = 1, Point = 90 },
			//new Score { StudentId = 2, Point = 80 }
			//		};

			//var result = students1.Join(
			//	scores, // qoşulacaq ikinci siyahı
			//	s => s.Id,  // birinci siyahının əlaqə açarı
			//	sc => sc.StudentId, // ikinci siyahının əlaqə açarı
			//	(s, sc) => new { s.Name, sc.Point }); // nəticə üçün seçim

			//foreach (var item in result)
			//	Console.WriteLine($"{item.Name} - {item.Point}");
			#endregion
			#region SingleAsync, FirstAsync ...
			
			var students = new List<Student>
			{
				new Student { Id = 1, Name = "Aysun", Group = "A", IsActive = true },
				new Student { Id = 2, Name = "Veysal", Group = "B", IsActive = false },
				new Student { Id = 3, Name = "Elvin", Group = "A", IsActive = true }
			};

			var activeStudent = students.FirstOrDefault(s => s.IsActive);
			Console.WriteLine(activeStudent?.Name);

			//first
			//Siyahıdan ilk uyğun elementi qaytarır.
			//Əgər tapmasa exception atır.
			var student =  students.First(s => s.Group == "A");

			//firstordefault
			//İlk uyğun elementi qaytarır,
			//əgər tapmasa null (və ya default dəyər) verir.
			//var student = students.FirstOrDefault(s => s.Group == "C");

			//if (student == null)
			//	Console.WriteLine("Tələbə tapılmadı");

			//single
			//Yalnız bir dənə uyğun element varsa qaytarır.
			//Əgər heç yoxdursa və ya bir neçə dənə varsa → exception atır.
			//var student = students.Single(s => s.Id == 5);

			//singleordefault
			//Eyni Single() kimidir,
			//amma tapmayanda null qaytarır.
			//var student = students.SingleOrDefault(s => s.Id == 5);
			#endregion
		}
	}
}




//	List<string> names = new List<string> { "Aysun", "Lala", "Maya", "Ayla" };

//	var filteredNames = names.Where(name => name.StartsWith("A"));

//          foreach (var name in filteredNames)
//          {
//              Console.WriteLine(name);
//          }

//			var employees = new List<Employee>
//{
//			new Employee { Name = "Aysun", Salary = 1200 },
//			new Employee { Name = "Veysal", Salary = 900 },
//			new Employee { Name = "Elvin", Salary = 1500 }
//};
//			var richEmployees = employees.Where(e => e.Salary > 1000);

//			foreach (var employee in richEmployees)
//			{
//				Console.WriteLine($"{employee.Name} - {employee.Salary}");
//			}

//var students = new List<Student>
//         {
//		   new Student { Name = "Aysun", Group = "A" },
//		   new Student { Name = "Veysal", Group = "B" },
//		   new Student { Name = "Elvin", Group = "A" }
//         };

//var grouped = students.GroupBy(s => s.Group);

//         foreach (var group in grouped)
//         {
//             Console.WriteLine("Group: " + group.Key);
//             foreach (var student in group)
//             {
//                 Console.WriteLine(" - " + student.Name);
//             }
//         }
