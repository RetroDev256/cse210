public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    // Renders underscores if the word is hidden
    public string RenderString()
    {
        if (_hidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}