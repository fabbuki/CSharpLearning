using System;

namespace Fibonacci
{
	class Iterative
	{
		static void Main ()
		{

			int position = 0; 
			int fibby = 0; 

			Console.WriteLine ("What nth Fibonacci do you want?"); 
			string line = Console.ReadLine (); 

			int value; 
			while (!int.TryParse (line, out value)) { //while the user has not typed in an int 
				Console.WriteLine ("You need to type in an integer, idiot. Try again:");  
				line = Console.ReadLine ();
			}

			position = Convert.ToInt32 (line); 

			fibby = IterativeFib (position); 

		}

		int IterativeFib (int position)
		{

			int Fib1 = 1;  
			int Fib2 = 1;  
			int myFib = 0; 

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
	}
}


