using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// delegate to point Greet function
public delegate void GreetFunctionDelegate(string message);

namespace TestMultithreadingAndDelegate.Utility
{
	/// <summary>
	/// Testing class for delegate
	/// </summary>
	class MyDelegate
	{
		/// <summary>
		/// a function to be pointed by delegate
		/// </summary>
		/// <param name="message"></param>
		public static void Greet(string message)
		{
			Console.WriteLine(message);
		}
	}
}
