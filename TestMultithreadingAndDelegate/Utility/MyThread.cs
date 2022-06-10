using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestMultithreadingAndDelegate.Utility
{
	/// <summary>
	/// Testing class for multithreading
	/// </summary>
	class MyThread
	{
		static int _sleepFor = CommonConstants.s_SleepFor;
		/// <summary>
		/// To create a loop for multithreading and sleep for 200 milisecond to make multithreading clear
		/// </summary>
		public static void ThreadWithoutParam()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
				Thread.Sleep(_sleepFor);
			}
		}

		public static void ThreadWithParam(object message)
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine($"{i} {message}");
				Thread.Sleep(_sleepFor);
			}
		}
	}
}
