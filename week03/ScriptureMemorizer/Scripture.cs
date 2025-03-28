using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = 3;
        var visibleWords = words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        return reference.GetDisplayText() + " " + string.Join(" ", words.Select(word => word.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return words.All(word => word.IsHidden());
    }
}
