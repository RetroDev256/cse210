public class Scripture
{
    private Reference _reference;
    private List<Word> _content;
    private Random _rng;

    // Functions required by Library class
    public Scripture(Reference reference, List<Word> content)
    {
        _rng = new Random();
        _reference = reference;
        _content = content;
    }

    public Scripture()
    {
        Scripture scripture = Library.GetRandom();
        _rng = scripture._rng;
        _reference = scripture._reference;
        _content = scripture._content;
    }

    // Print the current verse representation
    public string RenderString()
    {
        string result = _reference.RenderString();
        result += "\n\n";
        foreach (Word word in _content)
        {
            result += word.RenderString();
            result += " ";
        }
        return result;
    }

    // Check if all the words are hidden - 
    // Function is required by the program to exit if all words are hidden
    public bool IsAllHidden()
    {
        foreach (Word word in _content)
        {
            if (!word.IsHidden()) return false;
        }
        return true;
    }

    public void HideMore()
    {
        // Hide 12 verses each time - this may attempt to hide
        // words that have already been hidden
        for (int i = 0; i < 12; i += 1)
        {
            int idx = _rng.Next(_content.Count);
            _content[idx].Hide();
        }
    }
}