namespace Lab2Q5;
public class NumCompare
{
	///<summary>
	///This method compares 2 numbers and returns the max
	///</summary>
	///<param name="number"></param>
	///<returns></returns>
	///Egan Okumu
	public static int Max(int n1, int n2)
	{
		int max;
		if(n1 > n2)
		{
			Console.WriteLine("{0} is the max",n1);
			max = n1;
		}
		else if(n2 > n1)
		{
			Console.WriteLine("{0} is the max",n2);
			max = n2;
		}
		else
		{
			Console.WriteLine("Both of these numbers are equal");
			max = n1;
		}
		return max;
	}
	///<summary>
	///This method compares 3 numbers and returns the max
	///</summary>
	///<param name="number"></param>
	///<returns></returns>
	///Egan Okumu
	public static int Max(int n1, int n2, int n3)
	{
		int max;
		if(n1 > n2 && n1 > n3)
		{
			Console.WriteLine("{0} is the max",n1);
			max = n1;
		}
		else if(n2 > n1 && n2 > n3)
		{
			Console.WriteLine("{0} is the max",n2);
			max = n2;
		}
		else if(n3 > n1 && n3 > n2)
		{
			Console.WriteLine("{0} is the max",n3);
			max = n3;
		}
		else
		{
			Console.WriteLine("All of these numbers are equal");
			max = n1;
		}
		return max;
	}
}
