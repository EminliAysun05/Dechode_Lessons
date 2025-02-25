using System.Collections.Concurrent;

namespace OOP;

public class Program
{
	static void Main(string[] args)
	{
		//shallow copy, deep copy
		//value tip deyerlerin default davranisi deep copydir.
		//int a = 5;
		//int b = a; // b = 5
		//a = 10;
		//      Console.WriteLine(a);
		//      Console.WriteLine(b);

		//shallow copy - referance tip deyerlerin default davranisi shallow copydir

		//MyClass m1 = new MyClass();
		//MyClass m2 = m1;
		//MyClass m3 = m2;
		//m2.name = "Aysun";

		//Console.WriteLine(m2.name);
		//      Console.WriteLine(m1.name);


		//MyClass m4 = new MyClass();
		//MyClass m1 = null;
		//MyClass m2 = new MyClass();
		//MyClass m3 = m2;
		//m1 = m3;


		MyClass m1 = new MyClass();
		MyClass m2 = new MyClass();
		MyClass m3 = m1;
		m1 = m2;
		m2 = m1;
		m1 = m1;

		//	MyClass m = new MyClass();//() constructor metodunu cagiririq
		//m.name
		//yeni folder+class yaratmaq ucun => ctrl+shift+a    folderName/className
		//ve ya hansisa class yaratmaq ucun => ctrl+ shift +a
		{

			//eyni ve ya ferqli namespace icinde
			//ic-ice class

			//class complex type data

		}

	}
	public class Person
	{
		//field 
		//datalarimizi saxladigimiz yer 
		//default deyeri int 
		//public int Age;
		//public string Name;


		////property
		////fieldlerin kenara kontrollu sekilde cixmasini temin eden quruluslara biz property deyirik
  //      public int age { get; set; }
		//encapsulation -- oop prinsipidir

	}

	public class MyClass 
	{
		//full property
		public string name = "kjasd";//field
		//public int Name //property
		//	{
		//		get
		//		{
		//			return name;
		//		} 
		//		set
		//		{
		//			name = value;
		//		}
		//	}

		//prop property
		//public int Age { get; set; }

		////auto property - ilk deyerini hemin an veririk

		//public string Name1 { get; set; } = "filankes";

		////ref readonly property
		////public string Name { get; set; } = "Aysun";
		//string name = "Aysun";
		//public ref readonly string Name => ref name; //lyamda expression

		////computed property - riyazi hesablamalar ucun istifade olunur
		//int num1 = 5;
		//int num2 = 10;
		//public int Sum{
		//	get => num1 + num2; }


}





}
#region


#endregion