public class Word
{
    // This class keeps track of a single word and whether it is shown or hidden.
    private string _text;
    private bool _isHidden;
    // a variable to indicate whether that word is shown or hidden (a boolean).

    public Word(string text)
    {
        // This constructor should accept the text of the word to save it as an attribute. In addition, the constructor will need to set the initial visibility of the word (whether it is shown or hidden). Notice that you should not need to pass in the visibility of the word. It can be set to be visible by default.
        _text =text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;        
    }

    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        //It gets the display text of that word, which would be either the word itself (for example, "prayer") or, if the word were hidden, this behavior would return underscores (for example, "______").
        string word = "";
        if (IsHidden() == true) {
            // var dashed = new string( '_', _text.Length);
            int length = _text.Length;
            word = new string( '_', length);
        }
        else {
            word = _text;
        }

        return word;        
    }
}