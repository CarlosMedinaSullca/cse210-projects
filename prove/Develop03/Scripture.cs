using System;
using System.Collections.Generic;
public class Scripture
{
    // This class keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
    private Reference _reference;
    private List<Word> _words;
    // notice it is a list of Word objects, rather than a list of strings.

    public Scripture(Reference Reference, string text)
    {
        // The constructor would have the responsibility of creating the list, and splitting up the words in the string to create Word objects for each one and put them in the list.
        _reference = Reference;

        _words = new List<Word>();

        char separator = ' ';
        string[] strinSplitted = text.Split(separator);

        foreach ( string i in strinSplitted)
        {
            Word w1 = new Word(i);
            _words.Add(w1);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        if (visibleWords.Count <= numberToHide){
            foreach (var word in visibleWords){
                word.Hide();
            }
        }
        else {
            for (int i=0; i < numberToHide; i++){
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }


    }
    public string GetDisplayText()
    {
        //The "display text" refers to the text with some words shown normally, and some replaced by underscores.

        // Creating an empty list of strings called words
        List<string> words = new List<string>();

        // Looping through the _words list of word objects, displayin each word object as a string and adding them to the words list
        foreach (Word w in _words) {
            words.Add(w.GetDisplayText());
        }
        
        // Joining the elements of the words list with a space separator
        string result = string.Join(" ", words);

        Console.WriteLine(_reference.GetDisplayText());

        return  result;

    }
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());

    }
}