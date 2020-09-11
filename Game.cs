using System;
using System.Dynamic;
using System.Threading;
using TextAdventure;

public class Game
{
	public Game()
	{
	}

	ConsoleKeyInfo cki;
	Inventory inv = new Inventory();
	Encounters enc = new Encounters();

	public void GameInitialize()
	{
		

		Console.WriteLine("Please. Give me your name: ");
		string name = Console.ReadLine();
		Console.Clear();
		Console.WriteLine($"Welcome {name}. I can see you understand the cloud's mood, they are unhappy with the presence of one of your brothers. The 'immortal one' they call him? \n" +
			$"You seek the answer to his defeat am i wrong? \n" +
			$"If you seek vengence for the one who turned on those who cared for him, look for the 3 pieces of 'the suit of mortality', you must have all 3 pieces if you wish to counteract \n" +
			$"your brother's immortality.");
		PickMove();
		Console.WriteLine("\n");
		Console.WriteLine("You now have 1/3 of the items.");
		PickMove();
		Console.WriteLine("\n");
        Console.WriteLine("You now have 2/3 of the items.");
		PickMove();
		Console.WriteLine("\n");
		Console.WriteLine("You now have all of the items.");
        Console.WriteLine("\n");
        Console.WriteLine("You have restored faith in humanity, please check your inventory one more time(i): ");
		cki = Console.ReadKey();
		if(cki.Key == ConsoleKey.I)
        {
			inv.WriteBoard();
        }

	}

	public void PickMove()
	{
		Inventory inv = new Inventory();
		Encounters enc = new Encounters();

		Console.WriteLine("Do you wish to proceed? \n" +
			"Press I for inventory || or any other key to continue");
		cki = Console.ReadKey();
		if (cki.Key == ConsoleKey.I)
		{
			inv.WriteBoard();
		}
        Console.WriteLine("");
			Console.WriteLine("Where would you like to start your adventure? \n" +
				"1. Cave of Will \n" +
				"2. Valley of Trust \n" +
				"3. Throne Room Of The Immortal");
			int key = Convert.ToInt32(Console.ReadLine());
			switch (key)
			{
				case 1:
					Console.WriteLine("You have chosen to test your will");
					enc.FirstEncounter();
					CaveOfWill();
					break;

				case 2:
                    Console.WriteLine("You have chosen to believe in others...");
					ValleyOfTrust();
					break;

				case 3:
					Console.WriteLine("You have chosen to face Fear eye to eye...");
					ThroneRoomOfTheImmortal();
				break;

				default:
					break;
			}
	}

	public void CaveOfWill()
    {
		Inventory inv = new Inventory();
		

		

        Console.WriteLine("You approach the entrance to the cave of will... \n" +
			"are you too scared to enter? it would be much easier to just go back to bed... \n" +
			"Please press 'N' if you would like to end your journey now || press any other button to continue:");
		cki = Console.ReadKey();
		if(cki.Key == ConsoleKey.N)
        {
            Console.WriteLine("You have failed the first challenge of Will... \n" +
				"Your journey ends here...");
			Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("You Decide to Enter the cave of will... \n" +
				"though you were hesitant, you decided to test your will against this journey... \n" +
				"and for that reason, you have passed the first test, the helmet for the armour you \n" +
				"are searching for has been granted to you.");
			inv.AddItems("*Helmet of Will");
        }
    }
	public void ValleyOfTrust()
    {
		Inventory inv = new Inventory();

        Console.WriteLine("You approach the oppening of a valley, where you find a man waiting. \n" +
			" 'please sir, do you happen to know where i can find one of the pieces of the 'suit of mortality'?' you ask \n" +
			"'trust is an interesting intuition. Use your definition of trust do determine your fait (enter numbers 1 - 3):  '");
		Console.WriteLine("1. Trust only oneself, never let down your guard. \n" +
			"2.Trust is found within friendship, those you call friends, are the ones to trust. \n " +
			"3.Trust everyone who desides your fait, it might be your only option.");
		int key = Convert.ToInt32(Console.ReadLine());

		switch (key)
        {
			case 3:
                Console.WriteLine("you fall off the cliff to your impending doom. as the pressure of the air flows between your body, you feel a slight ease at heart. \n" +
					"the man from earlier had protected you somehow, you have lived. \n" +
					"'As a reward for trusting me, and yourself. Please take the 'leggings of Trust''");
				inv.AddItems("*Leggings of Trust");
				break;

			default:
				break;
        }
    }
	public void ThroneRoomOfTheImmortal()
    {
		Inventory inv = new Inventory();

        Console.WriteLine("You approach the opening to a castle, a dark and mysterious aura aligns it. \n" +
			"As you come up to the throne room you see the last piece of the armour,'The Chestplate of Mortality'. You take it, and as you throw the iron onto your shoulders, you hear a voice tell you: \n " +
			"'Brother, you have come a long way. You have proven to me that even though your life is restricted in the limit you spend on Earth, That believing in onesself is even more important. \n " +
			"Spread this message umongst the people. Use the sword to strike me down.' \n " +
			"You pick up the sword, charge at your brother, and finish the suffering.");
		inv.AddItems("*The Chestplate of Mortality");
		inv.AddItems("**Sword of the protector");
		inv.AddItems("***Medal of Valor : Hero");

    }

	
	
}

