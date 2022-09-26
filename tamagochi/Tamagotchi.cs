using System;
using System.Collections.Generic;

public class Tamagotchi
{
    private int hunger = 0;
    private int boredom = 0;
    private List<string> words = new();
    private bool isAlive;
    private Random generator;
    public string name;

    public Tamagotchi()
  {
    generator = new Random();
    isAlive = true;
  }

    public void Feed()
    {
        Console.WriteLine($" [{name}] eats and becomes less hungry");
        hunger -= 2;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }

    public void Hi()
    {
        int wordNum = generator.Next(words.Count);
        Console.WriteLine($" [{name}] says: {words[wordNum]}");
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        Console.WriteLine($" [{name}] learns: {word}");
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Vocabulary: {words.Count} words");
    }

    public void GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {
        Console.WriteLine($" [{name}] is now less bored!");

        boredom -= 2;
        if (boredom < 0)
        {
            boredom = 0;
        }
    }

    
}