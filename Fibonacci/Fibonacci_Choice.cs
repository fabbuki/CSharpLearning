using System;
using System.Diagnostics;
using System.Threading;

namespace Fibonacci
{
	class Iterative
	{
		static void Main ()
		{

			int position = 0; 
			decimal fibby = 0; 

			Console.WriteLine ("What nth Fibonacci do you want?"); 
			string line = Console.ReadLine (); 

			int value; 
			while (!int.TryParse (line, out value)) { //while the user has not typed in an int 
				Console.WriteLine ("You need to type in an integer, idiot. Try again:");  
				line = Console.ReadLine ();
			}

			position = Convert.ToInt32 (line); 

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();

			fibby = IterativeFib (position); 

			//stop the clock 
			stopWatch.Stop();
			//TimeSpan ts = stopWatch.Elapsed;

			Console.WriteLine("The Fibonacci at position {0} is {1}", position, fibby); 

			// Format and display the TimeSpan value. 
			// Write result
			Console.WriteLine("Time elapsed: {0}",
				stopWatch.Elapsed);


			Console.WriteLine ("Press any key to quit"); 
			Console.ReadLine (); 


		}

		static decimal IterativeFib (int position)
		{

			decimal Fib1 = 1;  
			decimal Fib2 = 1;  
			decimal myFib = 0; 

			if (position <= 2) {

				myFib = 1; 
				return myFib; 

			} else {

				for (int i = 3; i <= position; i++) {
			
					myFib = Fib1 + Fib2; 

					//advance the Fib1 and Fib2 holders for the next calculation 
					Fib1 = Fib2; 
					Fib2 = myFib; 
				}
				return myFib; 

			}

		}

		static decimal RecursiveFib (int position) {

		}
	}
}


