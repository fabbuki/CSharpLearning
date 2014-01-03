using System;

namespace FoodQTY
{
	class OneFoodDay
	{
		static void Main ()
		{

			int howManyPeeps = 0; 
			decimal numPeeps = 0; 

			Console.WriteLine ("This will help calculate how much food to buy per person."); 
			Console.WriteLine ("\n"); 
			Console.WriteLine ("How many people are attending?"); 

			getNumberPeeps (ref howManyPeeps);

			numPeeps = (decimal)howManyPeeps;  

			//Breakfast
			Console.WriteLine ("\n"); 
			Console.WriteLine ("Breakfast"); 
			Console.WriteLine ("-------------"); 

			//pancakes, eggs, orange juice, coffee 
			decimal pancakes = Decimal.Multiply((decimal)2,numPeeps); 
			decimal eggs = Decimal.Multiply((decimal)2,numPeeps); 
			decimal gallonsOJ = Decimal.Multiply((decimal)1/8,numPeeps); //gallons, assumes 1 pint per person 
			decimal coffeeCups = Decimal.Multiply((decimal)1.5,numPeeps); //cups of coffee 

			Console.WriteLine ("You must make {0} pancakes, scramble a total of {1} eggs, " +
				"buy {2} gallons of OJ, and make {3} cups of coffee for breakfast.", pancakes, eggs, gallonsOJ, coffeeCups); 

			//Lunch
			Console.WriteLine ("\n"); 
			Console.WriteLine ("Lunch"); 
			Console.WriteLine ("-------------"); 

			decimal tacos = Decimal.Multiply(2,numPeeps); 
			decimal riceCups =  Decimal.Multiply((decimal)0.5,numPeeps); //a half cup of uncooked per person 
			decimal hotCocoa = Decimal.Multiply((decimal)1.5,numPeeps); //cups of hot cocoa 
			decimal cupsSalsa = Decimal.Multiply((decimal)1/2,numPeeps); //1/2 cup of salsa per person 
			decimal bagChips = Decimal.Multiply((decimal)1/4,numPeeps); //4 people consume one large bag of chips 

			Console.WriteLine ("You must make {0} tacos, cook {1} raw cups of rice, " +
				"make {2} cups of hot cocoa, buy {3} bags of chips, and make {4} cups of salsa.", tacos, riceCups, hotCocoa, bagChips, cupsSalsa); 

			//Dinner
			Console.WriteLine ("\n"); 
			Console.WriteLine ("Dinner"); 
			Console.WriteLine ("-------------");   

			decimal servingsRatatouille = numPeeps; 
			decimal servingsSpaghetti = numPeeps; 
			decimal breadLoavesReal = Decimal.Multiply((decimal)1/8,numPeeps); 
			decimal numberBreadLoaves = Convert.ToInt32(Math.Ceiling(breadLoavesReal)); 
			decimal poundsOfCheese = Decimal.Multiply((decimal)1/4,numPeeps); //assumes 1/4 lb of cheese per person
			decimal wineBottles = Decimal.Multiply((decimal)1/3,numPeeps); //assumes three people consume one wine bottle
			decimal pies = Decimal.Multiply((decimal)1/8,numPeeps); //assumes 8 people consume one pie 

			Console.WriteLine ("You must make {0} servings of ratatouille, {1} servings of spaghetti and sauce, " +
				"bake {2} loaves of bread, buy {3} pounds of cheese, buy {4} bottles of wine, " +
				"and buy {5} pies.", servingsRatatouille, servingsSpaghetti, numberBreadLoaves, poundsOfCheese, wineBottles, pies); 


		}

		static void getNumberPeeps (ref int p)
		{

			int value; 
			string line = Console.ReadLine ();

			while (!int.TryParse (line, out value)) { //while the user has not typed in an int 
				Console.WriteLine ("You need to type in an integer, idiot. Try again:");  
				line = Console.ReadLine ();
			}

			p = Convert.ToInt32 (line);  //will assign the value to whatever is passed in 
				
		}
	}
}

