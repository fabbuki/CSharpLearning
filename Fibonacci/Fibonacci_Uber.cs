using System;
using System.Diagnostics;
using System.Threading;

namespace Fibonacci
{
	class Clever
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

			Stopwatch stopWatch = new Stopwatch ();
			stopWatch.Start ();

			fibby = CleverFib (position); 

			//stop the clock 
			stopWatch.Stop ();
			//TimeSpan ts = stopWatch.Elapsed;

			Console.WriteLine ("The Fibonacci at position {0} is {1}", position, fibby); 

			// Format and display the TimeSpan value. 
			// Write result
			Console.WriteLine ("Time elapsed: {0}",
				stopWatch.Elapsed);


			Console.WriteLine ("Press any key to quit"); 
			Console.ReadLine (); 


		}

		static decimal IterativeFib (int position)
		{

			decimal Fib1 = 0;  
			decimal Fib2 = 1;  
			decimal myFib = 0; 

			if (position == 0) {
				myFib = 0; 
				return myFib; 
			}
			else if (position == 1) {
				myFib = 1; 
				return myFib; 

			} else {

				for (int i = 2; i <= position; i++) {
			
					myFib = Fib1 + Fib2; 

					//advance the Fib1 and Fib2 holders for the next calculation 
					Fib1 = Fib2; 
					Fib2 = myFib; 
				}
				return myFib; 

			}

		}

		static decimal RecursiveFib (int position)
		{

			decimal myFib = 0; 

			if (position == 0) {
				myFib = 0; 
				return myFib; 
			}
			else if (position == 1) {
				myFib = 1; 
				return myFib; 
			}
			 else {

				myFib = RecursiveFib (position - 1) + RecursiveFib (position - 2); 
			}

			return myFib; 
		}

		//http://www.math.hmc.edu/funfacts/ffiles/10002.4-5.shtml
		//fun fact, this is actually slower than the iterative method for some reason... 
		//I think C# just sucks at math 
		static decimal CleverFib (int position) 
		{
			decimal myFib = 0; 
			decimal Phi = (decimal)(1+Math.Sqrt(5))/2; 
			decimal phi = (decimal)(1-Math.Sqrt(5))/2; 

			if (position == 0) {
				myFib = 0; 
				return myFib; 
			}
			else if (position == 1) {
				myFib = 1; 
				return myFib; 
			}
			else {
				myFib = (decimal)((Math.Pow((double)Phi, (double)position)-Math.Pow((double)phi, (double)position)) / (double)Math.Sqrt(5)); 
				//myFib = Math.Round(myFib); 
				return myFib; 
			}
		}
	}
}


