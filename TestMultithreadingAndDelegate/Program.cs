using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestMultithreadingAndDelegate.Utility;

namespace TestMultithreadingAndDelegate
{
	class Program
	{
		/// <summary>
		/// To test multithreading and delegate
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			/* Thread thread1 = new Thread(new ThreadStart(MyThread.ThreadWithoutParam));
			Thread thread2 = new Thread(new ThreadStart(MyThread.ThreadWithoutParam));
			Thread thread3 = new Thread(new ThreadStart(MyThread.ThreadWithoutParam));

			thread1.Start();
			thread2.Start(); */

			// Joining threads
			// thread 1 will work for 200 milisecond until it completes the task after that thread 2 and thread 3 will start
			/* thread1.Start();
			thread1.Join();
			thread2.Start();
			thread3.Start(); */

			/* Thread thread3 = new Thread(new ParameterizedThreadStart(MyThread.ThreadWithParam));
			Thread thread4 = new Thread(new ParameterizedThreadStart(MyThread.ThreadWithParam));

			thread3.Start("Hi from ThreadWithParam");
			thread4.Start("Hi from ThreadWithParam"); */

			// calling GreetFunctionDelegate delegate
			GreetFunctionDelegate del = new GreetFunctionDelegate(MyDelegate.Greet);
			del("Hello Delegate");

			Console.ReadKey();
		}
	}
}
