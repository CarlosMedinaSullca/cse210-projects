using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompText}");
            Console.WriteLine(entry._entryText);
        }
    }

    public void SaveToFile(string file)
    {
        string fileName = file;
        using (StreamWriter outputFile = new StreamWriter (fileName))
        {
            // Adding text to the file with the WriteLine method
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._prompText}~ {entry._entryText}");
            }    
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            string promptLine = parts[0];
            string userAnswer = parts[1];
            Console.WriteLine(promptLine);
            Console.WriteLine(userAnswer);
        }
    }



}