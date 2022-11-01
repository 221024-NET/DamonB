using System;

namespace CoinFlipper
{
	public class CoinFlipper
	{
		// Fields
		public int test = 0;

		// Constructor
		public CoinFlipper() { }
		// Methods
		//[access modifier] [modifier] [return type] [method name] ([parameters])
		public static void Main()
		{
			bool loop = true;
			while (loop)
			{
				CoinFlip(); // models the ENTIRE behavior

				Console.WriteLine("Would you like to flip more coins?");
				Console.WriteLine("Enter 'y' or 'Y' to run again, or anything else to exit:");
				string playAgain = Console.ReadLine().ToUpper();

				if (playAgain.Equals("Y"))
				{
					loop = true;
				}
				else
				{
					loop = false;
				}

			}
		}

		public static void CoinFlip()
		{
			Console.WriteLine("Starting Coin Flipper:");

			Console.WriteLine("Enter the number of coins to flip: ");

			string UserNumber = Console.ReadLine();
			int Num = 0;

			try
			{
				Num = Int32.Parse(UserNumber);
				if (Num <= 0)
				{
					throw new Exception("Argument may not be negative");
				}
			}
			catch (InvalidOperationException e)
			{
				Console.WriteLine("A less specific catch: " + e.Message);
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine("The least specific catch: " + e.Message);
			}

			Flip(Num);
		}

		//[access modifier] [modifier] [return type] [method name] ([parameters])
		public static void Flip(int Num)
		{
			var rand = new Random();

			for (int i = 0; i < Num; i++)
			{
				int coin = rand.Next(2);
				Console.WriteLine(HoT(coin));
			}
		}

		public static string HoT(int coin)
		{
			if (coin == 0)
			{
				return "Heads";
			}
			else
			{
				return "Tails";
			}
		}
	}
}