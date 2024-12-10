public class Comment 
{
    public string _name;
    public string _text;

    public string DisplayCommenterAndText() {

        return $"{_name}: {_text}";
    }

}