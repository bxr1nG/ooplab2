using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	class Program
	{
		static void Main(string[] args)
		{
			// TYPES

			Console.Write("Hello, what is your name?   ");
			string name = Console.ReadLine();

			Console.Write("What is the first letter of your last name?   ");
			char lastName = Console.ReadKey().KeyChar;
			Console.ReadLine();

			Console.Write("How old are you?   ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.Write("What is your height (use ,)?   ");
			float height = float.Parse(Console.ReadLine());

			Console.Write("Are you student (use y or n)?   ");
			char studAns = Console.ReadKey().KeyChar;
			Console.ReadLine();
			bool isStudent;
			if (studAns == 'y')
				isStudent = true;
			else
				isStudent = false;

			Console.WriteLine();
			Console.WriteLine("Hello, " + name + " " + lastName + "!");
			Console.WriteLine("Your height is " + height + " and you are " + age + ".");
			Console.WriteLine(isStudent ? "You are student!" : "You are not student(");

			//-----
			
			double b = 429.324;
			float c = -23.1242f;
			short e = 23477;
			byte f = 100;

			// explicit conversions

			Console.WriteLine();
			Console.WriteLine("Explicit conversions");

			int x = (int)b;
			Console.WriteLine("Double " + b + " to Int " + x);
			double y = (double)c;
			Console.WriteLine("Float " + c + " to Double " + y);
			long z = (long)e;
			Console.WriteLine("Short " + e + " to Long " + z);
			int m = (int)f;
			Console.WriteLine("Byte " + f + " to Int " + m);
			float n = (float)e;
			Console.WriteLine("Short " + e + " to Float " + n);

			// implicit conversions

			Console.WriteLine();
			Console.WriteLine("Implicit conversions");

			int q = e;
			Console.WriteLine("Short " + e + " to Int " + q);
			double d = c;
			Console.WriteLine("Float " + c + " to Double " + d);
			long a = e;
			Console.WriteLine("Short " + e + " to Long " + a);
			int w = f;
			Console.WriteLine("Byte " + f + " to Int " + w);
			ulong r = f;
			Console.WriteLine("Byte " + f + " to Ulong " + r);

			// class convert

			Console.WriteLine();
			Console.WriteLine("Class convert");

			bool o = true;
			double u = Convert.ToDouble(o);
			Console.WriteLine("Bool " + o + " converted to Double " + u + " uses Convert.ToDouble");

			//-----

			Console.WriteLine();
			Console.WriteLine("Packing and unpacking");

			int frst = 123;
			object obj = frst;
			int sec = (int)obj;
			Console.WriteLine("Int " + frst + " packed in Object " + obj + " and unpacked in Int " + sec);

			//-----

			Console.WriteLine();
			Console.WriteLine("Implicitly typed variables");

			var var1 = 122;
			var var2 = 12.21f;
			var var3 = "Variable";
			var var4 = 'v';
			Console.WriteLine("There is 4 implicitly typed variables: Int " + var1 + ", float " + var2 + ", string " + var3 + " and char " + var4);

			//-----

			Console.WriteLine();
			Console.WriteLine("Nullable type");

			int? nl = null;
			Console.WriteLine("Making nullable variable and checking it");
			if (nl.HasValue)
				Console.WriteLine("Variable has value");
			else
				Console.WriteLine("Variable is nullable");
			Console.WriteLine("Adding value and checking");
			nl = 5;
			if (nl.HasValue)
				Console.WriteLine("Variable has value");
			else
				Console.WriteLine("Variable is nullable");

			//-----

			Console.WriteLine();
			Console.WriteLine("Making variable with var");
			var simp = 12;
			Console.WriteLine(simp);
			Console.WriteLine("Changing type of variable");
			simp = 'a';
			Console.WriteLine(simp);
			Console.WriteLine("The variable has not changed its type, since it received it during initialization");


			
			// STRINGS

			string str1 = "First string";
			string str2 = "Second string";
			string str3 = "Third string";

			Console.WriteLine();
			Console.WriteLine("String comparison of " + str1 + " and " + str2 + " showed similarity " + String.Compare(str1, str2));

			string[] strs = new string[] { str1, str2, str3 };
			String str123 = String.Join(" ", strs);
			Console.WriteLine("Concatenated string: " + str123);

			Console.WriteLine("Splitting into words:");
			string[] words = str123.Split(new char[] { ' ' });
			foreach (string s in words)
			{
				Console.WriteLine(s);
			}

			string str123mod = str123.Substring(5);
			str123mod = str123mod.Substring(0, str123mod.Length - 6);
			str123mod = str123mod.Trim();
			Console.WriteLine("Trim string: " + str123mod);

			string subString = "megastring ";
			str123mod = str123mod.Insert(7, subString);
			Console.WriteLine("Adding 'megastring ': " + str123mod);

			str123mod = str123mod.Remove(17, 7);
			Console.WriteLine("'Second ' removed: " + str123mod);

			int x1 = 8;
			int x2 = 7;
			string res = $"{x1} + {x2} = {x1 + x2}";
			Console.WriteLine("String interpolation: " + res);

			string strFill = "abc";
			string strNull = null;
			string strEmpty = "";
			string[] strCheck = new string[] { strFill, strNull, strEmpty };
			Console.WriteLine("String null or empty check:");
			foreach (string s in strCheck)
			{
				if (String.IsNullOrEmpty(s))
					Console.WriteLine("(\"{0}\") is null or empty", s);
				else
					Console.WriteLine("(\"{0}\") is not null or empty", s);
			}

			Console.WriteLine("Working with StringBuilder:");
			StringBuilder sb = new StringBuilder("ello World");
			Console.WriteLine(sb);
			sb.Append("!");
			sb.Insert(0, "H");
			Console.WriteLine(sb);
			sb.Replace("World", "C#");
			Console.WriteLine(sb);
			sb.Remove(5, 3);
			Console.WriteLine(sb);


			
			// ARRAYS

			Console.WriteLine();
			Console.WriteLine("Two-dimensional array:");
			int[,] myTArr = new int[5, 5];
			Random ran = new Random();

			for (int k = 0; k < 5; k++)
			{
				for (int j = 0; j < 5; j++)
				{
					myTArr[k, j] = ran.Next(1, 20);
					Console.Write("{0}\t", myTArr[k, j]);
				}
				Console.WriteLine();
			}

			Console.WriteLine();
			Console.Write("Array: ");
			string[] arrOfStr = new string[] { "Lorem", "ipsum", "dolor", "sit", "amet", "consectetur", "adipiscing" };
			foreach (string s in arrOfStr)
			{
				Console.Write(s + " ");
			}
			Console.WriteLine();
			int arrAm = arrOfStr.Length;
			Console.WriteLine("Number of array elements: " + arrAm);
			Console.Write("Enter the item number: ");
			int arrNum = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the item value: ");
			string newItem = Console.ReadLine();
			arrOfStr[arrNum - 1] = newItem;
			Console.Write("Array: ");
			foreach (string s in arrOfStr)
			{
				Console.Write(s + " ");
			}
			Console.WriteLine();
			Console.WriteLine();

			int i = 0;
			int[][] myArr = new int[3][];
			myArr[0] = new int[2];
			myArr[1] = new int[3];
			myArr[2] = new int[4];

			for (i = 0; i < 2; i++)
			{
				myArr[0][i] = ran.Next(1, 20);
				Console.Write("{0}\t", myArr[0][i]);
			}
			Console.WriteLine();
			for (i = 0; i < 3; i++)
			{
				myArr[1][i] = ran.Next(1, 20);
				Console.Write("{0}\t", myArr[1][i]);
			}
			Console.WriteLine();
			for (i = 0; i < 4; i++)
			{
				myArr[2][i] = ran.Next(1, 20);
				Console.Write("{0}\t", myArr[2][i]);
			}
			Console.WriteLine();

			var varArr = myArr;
			var varStr = newItem;



			// TUPLES

			(int myAge, string myName, char, string, ulong myTupNum) tup = ( 18, "Danil", 'V', "student", 9876543210 );
			Console.WriteLine("Tuple: " + tup);
			Console.WriteLine("Tuple (1, 3, 4): " + tup.Item1 + ", " + tup.Item3 + ", " + tup.Item4);
			char myLastName = tup.Item3;
			string myProf = tup.Item4;

			(int, string, char, string, ulong) tup2 = (1337, "Mihail", 'Z', "Mafioznik", 88005553535);
			Console.WriteLine("Tuple 2: " + tup2);
			Console.WriteLine("Comparison of 2 tuples: " +
				((tup.Item1 > tup2.Item1) ? "Item from first tuple is bigger" : "Item from second tuple is bigger") + ", " +
				(String.Compare(tup.Item2, tup2.Item2)) + ", " +
				(tup.Item3.CompareTo(tup2.Item3)) + ", " +
				(String.Compare(tup.Item4, tup2.Item4)) + ", " +
				((tup.Item5 > tup2.Item5) ? "Item from first tuple is bigger" : "Item from second tuple is bigger"));



			// LOCAL FUNCTION

			Console.WriteLine();
			Console.Write("Array: ");
			int[] funcArr = new int[7];
			for (i = 0; i < funcArr.Length; i++)
				Console.Write((funcArr[i] = ran.Next(1, 20)) + " ");
			Console.WriteLine();
			Console.WriteLine("String is 'lorem'");
			var funcRes = GetResult(funcArr, "lorem");
			Console.WriteLine("Elements of local function in tuple: " + funcRes.Item1 + ", " + funcRes.Item2 + ", " + funcRes.Item3 + ", " + funcRes.Item4);



			// CHECKED/UNCHECKED

			checked
			{
				Console.WriteLine();
				Console.Write("Checked max value: ");
				int val = int.MaxValue;
				Console.WriteLine(val);
			}

			unchecked
			{
				Console.WriteLine();
				Console.Write("Unchecked max value: ");
				int val = int.MaxValue;
				Console.WriteLine(val + val + 2 + val);
			}
		}

		static Tuple<int, int, int, char> GetResult(int[] numbers, string str)
		{
			int max = numbers[0];
			int min = numbers[0];
			int sum = 0;
			char let;

			foreach (int s in numbers)
			{
				if (max < s)
					max = s;
				if (min > s)
					min = s;
				sum += s;
			}

			let = str[0];

			return new Tuple<int, int, int, char>(max, min, sum, let);
		}
	}
}
