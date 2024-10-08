using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference ScriptureReference { get; private set; }
    private List<Word> Words { get; set; }

    public Scripture(string reference, string text)
    {
        ScriptureReference = new Reference(reference);
        Words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
        ScriptureReference.Display();
        foreach (var word in Words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords()
    {
        Random rand = new Random();
        int wordsToHide = 3;
        int hiddenCount = 0;

        while (hiddenCount < wordsToHide)
        {
            int index = rand.Next(Words.Count);
            if (!Words[index].IsHidden)
            {
                Words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool AreAllWordsHidden()
    {
        foreach (var word in Words)
        {
            if (!word.IsHidden)
                return false;
        }
        return true;
    }
}
