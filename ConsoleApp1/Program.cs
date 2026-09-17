
int hp = 100;
int hp2 = 100;

Console.WriteLine("välj namn");

string namn1 =  Console.ReadLine();

string namn2 = Console.ReadLine();

Console.WriteLine($"Hej {namn1} och {namn2}");

while (hp > 0 && hp2 > 0)
{
    Console.WriteLine("båda lever");
   int skada = Random.Shared.Next(10, 20);
   int skada2 = Random.Shared.Next(10, 20);
   hp = Math.Max(0, hp - skada);
   hp2 = Math.Max(0, hp2 - skada2);
   Console.WriteLine($"{namn1} har {hp} kvar och {namn2} har {hp2} kvar");
    
}


if (hp > 0 && hp2 == 0)
{
    Console.WriteLine($"{namn1} vann");
}
else if(hp == 0 && hp2 > 0)
{
    Console.WriteLine($"{namn2} vann");
}

else if (hp == 0 && hp2 == 0)
{
    Console.WriteLine("oavgjort");
}

Console.ReadLine();
