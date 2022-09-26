using System;

Console.WriteLine("Welcome to Tamagotchi asshole!");

Tamagotchi myTama = new Tamagotchi();

Console.WriteLine("Choose a freaking name for your Tamagotchi!");
myTama.name = Console.ReadLine();

Console.WriteLine($"Fucking fantastic! {myTama.name} you are done!");

while (myTama.GetAlive() == true)
{
  Console.Clear();
  myTama.PrintStats();
  Console.WriteLine("What the hell do you want to do now?");
  Console.WriteLine($"1. Teach {myTama.name} a new fucking word");
  Console.WriteLine($"2. Talk to {myTama.name}");
  Console.WriteLine($"3. Feed {myTama.name}");
  Console.WriteLine($"4. Maybe waste my time to to do nothing");

  string doWhat = Console.ReadLine();
  if (doWhat == "1")
  {
    Console.WriteLine("What word?");
    string word = Console.ReadLine();
    myTama.Teach(word);
  }
  if (doWhat == "2")
  {
    myTama.Hi();
  }
  if (doWhat == "3")
  {
    myTama.Feed();
  }
  else
  {
    Console.WriteLine("Doing nothing...");
  }
  myTama.Tick();
  
}

Console.WriteLine($"Well la di da! {myTama.name} is already dead!");
Console.WriteLine("Press ENTER to leave dipshit!!!");
Console.ReadLine();