using System.Security.Cryptography.X509Certificates;

namespace Dechode_Lessons;

public class Program
{



	#region SumOfDigits
	static void Main(string[] args)
	{
            Console.WriteLine(GDC(48,10));
           


		//48 10
		//10 8
		//8 2 
		//2 0


	}
	static int GDC(int a, int b)
	{
		if (b == 0)
			return a;
		return GDC(b, a % b);

	}
	#endregion

	#region Ən Böyük Ortaq Bölən
	//(48, 12)

	#endregion

	MyClaa m = new()
	{
		Name = "sksks"
	};
       

    }

class MyClaa
{
	public string Name { get; init; } = "lsls";
	public MyClaa()
	{
		Name = "lslslsl";
	}
}
// Console.WriteLine(SumOfDigits(1234));

//static int SumOfDigits(int n)
//{
//	if (n == 0) return 0;
//	return (n % 10) + SumOfDigits(n / 10);
//	//1234 % 10 = 4   + SumOfDigits(123)
//	//123 % 10 = 3   + SumOfDigits(12)
//}
//int age = 25;
//object age_ = 25; //boxing
//int newAge = (int)age_; //unboxing
//         Console.WriteLine(newAge*5);

//		bool isActive = true;

//compile seviyyesinde
//var x = 5;
//x = "ksdkdkdk";
//Console.WriteLine(x);

//runtime seviyyesinde
//dynamic y = 5;
//y = "sskkssk";
//Console.WriteLine(y);

//int a = 3000;
//float f = a;
//         Console.WriteLine(f);

//int x = 3000000;
//short y = (short)x;
//         Console.WriteLine(y);

//checked
//{
//	int x = 3000000;
//	short y = (short)x;
//	Console.WriteLine(y);
//}
