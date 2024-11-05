namespace Casino
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> kartya = new List<int>();
			bool folytatas = true;
			int penz = 500000;
			int chip = 0;

			
			
			
			
			while (folytatas)
			{
				Console.WriteLine("Üdvözöllek a Casinomban! Kérlek Válassz egy menüpontott az alánniak közül!");
                Console.WriteLine("1. pénz összeg megtekintése");
                Console.WriteLine("2. 'chip' összeg megtekintése");
				Console.WriteLine("3. pénz átváltása 'chip'-pé");
                Console.WriteLine("4. 'chip' átváltása pénzre");
                Console.WriteLine("5. Black Jake(21)");
                Console.WriteLine("6. póker");
				Console.WriteLine("7. 5 card draw");
                Console.WriteLine("8. rulett");
                Console.WriteLine("9. lóverseny");
                Console.WriteLine("10. félkarú rabló");
                Console.WriteLine("11. kilépés");
				int menuvalasztas = Convert.ToInt32(Console.ReadLine());
				switch (menuvalasztas)
				{
					case 1:
						{
                            Console.WriteLine();
                        }
						break;
						
				}
            
			}
			Console.ReadLine();
		}

		static void BlackJack()
		{
			
		}

		static void Poker()
		{
			
		}

		static void FiveCardsDraws()
		{

		}

		static void Rulett()
		{

		}

		static void LoVeresny()
		{

		}
		static void FelkaruRablo()
		{

		}
	}
}
