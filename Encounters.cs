using System;
using System.Threading;
using System.Threading.Tasks;
using TextAdventure;

public class Encounters
{
	static Random rand = new Random();
	public void FirstEncounter()
    {
		Combat(false,"Guardian", 1, 5);
    }

    public static void Combat(bool random, string name, int power, int health)
    {
        string n = "";
        int p = 0;
        int h = 0;
        if(random)
        {

        }
        else
        {
            n = name;
            p = power;
            h = health;
        }
        while (h>0)
        {
			Console.Clear();
            Console.WriteLine($"{n} || {p} || {h}");
            Console.WriteLine("========================");
            Console.WriteLine("||(A)ttack  (D)efend  ||");
            Console.WriteLine("||  (R)un     (H)eal  ||");
            Console.WriteLine("========================");
            string temp = Console.ReadLine();
            if (temp.ToLower() == "a" || temp.ToLower() == "attack")
            {
                //Attack
                Console.WriteLine($"You use your strength to attack {n}, as you pass you take damage in return");
				int damage = p - Program.currentPlayer.armorValue;
				if (damage < 0)
					damage = 0;
				int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1,4);
                Console.WriteLine($"you lost {damage} and deal {attack} damage.");
				Program.currentPlayer.health -= damage;
				h -= attack;
            }
            else if (temp.ToLower() == "d" || temp.ToLower() == "defend")
            {
				//Defend
				Console.WriteLine($"{n} lunged towards your direction, you take a defensive stance and counter his attack");
				int damage = (p/4) - Program.currentPlayer.armorValue;
				if (damage < 0)
					damage = 0;
				int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;
				TakeDamage();
				Console.WriteLine($"you lost {damage} and deal {attack} damage.");
				Program.currentPlayer.health -= damage;
				h -= attack;
			}
            else if (temp.ToLower() == "r" || temp.ToLower() == "run")
            {
                //Run
				if(rand.Next(0,2) == 0)
                {
                    Console.WriteLine($"As you try to sprint away from the {n}, its speed was too fast, he blocked your exit, striking you in the process.");
					int damage = p - Program.currentPlayer.armorValue;
					if (damage < 0)
						damage = 0;
                    Console.WriteLine($"You lose {damage} health and are unable to escape.");
					TakeDamage();
					Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"You use your speed to maneuver your way to safety, you have escaped from {n}");
					Console.ReadKey();
					//go to store
                }
                
            }
            else if (temp.ToLower() == "h" || temp.ToLower() == "heal")
            {
				//Heal
				health += 3;
                Console.WriteLine($"You manage to heal up a bit, your health has gone up by 3.");
                Console.WriteLine($"While you were healing, the {n} took advantage and struck you.");
				int damage = p - Program.currentPlayer.armorValue;
				if (damage < 0)
					damage = 0;
				TakeDamage();
				Console.WriteLine($"{n} hit you for {damage} health.");
				Console.ReadKey();
			}
			Console.ReadKey();
        }
    }

	static void TakeDamage()
	{
		Console.Clear();
		Thread.Sleep(200);
		PrintDamage();
		Thread.Sleep(200);
		Console.Clear();
		Thread.Sleep(200);
		PrintDamage();
		Thread.Sleep(200);
		Console.Clear();
		Thread.Sleep(200);
		PrintDamage();
		Thread.Sleep(200);
		Console.Clear();
		Thread.Sleep(200);
		PrintDamage();
		Thread.Sleep(200);
		Console.Clear();
		Thread.Sleep(200);
		PrintDamage();
		Thread.Sleep(200);
		Console.Clear();
		Thread.Sleep(200);
		PrintDamage();
		Thread.Sleep(200);
		Console.Clear();
		Thread.Sleep(200);
		PrintDamage();
		Thread.Sleep(200);
		Console.Clear();
		Thread.Sleep(200);
		PrintDamage();
		Thread.Sleep(200);

	}

	static void PrintDamage()
	{
		Console.WriteLine("x            x");
		Console.WriteLine(" x          x");
		Console.WriteLine("  x        x");
		Console.WriteLine("   x      x");
		Console.WriteLine("    x    x");
		Console.WriteLine("     x  x");
		Console.WriteLine("      xx");
		Console.WriteLine("      xx ");
		Console.WriteLine("     x  x ");
		Console.WriteLine("    x    x ");
		Console.WriteLine("   x      x ");
		Console.WriteLine("  x        x ");
		Console.WriteLine(" x          x ");
		Console.WriteLine("x            x ");
	}



}
