using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] wordArray = text.Split(" ");
        foreach (string wordString in wordArray)
        {
            Word newWord = new Word(wordString);
            _words.Add(newWord);
        }
    }
    public string GetDisplayText()
    {
        string newReference = _reference.GetDisplayText();
        newReference += " ";
        foreach (Word word in _words)
        {
            newReference += word.GetDisplayText();
            newReference += " ";
        }
        return newReference;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        if (IsCompletelyHidden() == false)
        {
            for (int i = 0; i < numberToHide; i++)
            {
                int randomIndex = randomGenerator.Next(0, _words.Count);
                Word randomWord = _words[randomIndex];
                while (randomWord.IsHidden() == true)
                {
                    randomIndex = randomGenerator.Next(0, _words.Count);
                    randomWord = _words[randomIndex];
                }
                randomWord.Hide();
            }
        }
    }

}