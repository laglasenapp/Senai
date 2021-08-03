using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		List<string> cities = new List<string>();
		cities.Add("New York");
		cities.Add("London");
		cities.Add("Mumbai");
		cities.Add("Chicago");

		foreach (string item in cities)
		{
			Console.WriteLine(item);
		}
	}
}