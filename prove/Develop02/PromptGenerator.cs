using System;

public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        // Random object
        Random rnd = new Random();

        // Get random index
        int index = rnd.Next(_prompts.Count);

        // Assingning a variable to the random prompt
        string randomPrompt = _prompts[index];

        // Return random prompt
        return randomPrompt;
    }
}