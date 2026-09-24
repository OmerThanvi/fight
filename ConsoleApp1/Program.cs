
int hp = 100;
int hp2 = 100;

Console.WriteLine("välj namn");

string namn1 =  Console.ReadLine();

string namn2 = Console.ReadLine();

Console.WriteLine($"Hej {namn1} och {namn2}. Tryck 1 för låg skada eller valfri knapp för högre skada");

while (hp > 0 && hp2 > 0)
{
   string Val1 = Console.ReadLine();

   int skada = 0;

   if (Val1 == "1")
    {
        skada = Random.Shared.Next(10,19);
        Console.WriteLine($"{namn1} använde attack 1");
    }
    else
    {
        skada = Random.Shared.Next(27,32);
        Console.WriteLine($"{namn1} använde attack 2");
    }
    hp2-=skada;
    Console.WriteLine($"{namn2} förlorade {skada} hp och har {hp2} kvar");

    if (hp2<=0)
    {
        break;
    }

    Console.WriteLine($"Det är {namn2}s tur! (HP: {hp2})");
    Console.WriteLine("Välj attack: Skriv 1 för Låg skada, eller valfri knapp för Hög skada");
    string val2 = Console.ReadLine();

    if (val2 == "1")
    {
        skada = Random.Shared.Next(10,19);
        Console.WriteLine($"{namn2} använde attack 1");
    }

    else
    {
        skada = Random.Shared.Next(27,32);
        Console.WriteLine($"{namn2} använde attack 2");
    }
    hp-=skada;
    Console.WriteLine($"{namn1} förlorade {skada} hp och har {hp} kvar");

    if(hp<=0)
    {
        break;
    }
    Console.WriteLine($"Det är {namn1}s tur! (HP: {hp})");
    Console.WriteLine("Välj attack: Skriv 1 för Låg skada, eller valfri knapp för Hög skada");
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

Console.ReadLine();
 }