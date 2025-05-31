public class Scripture
{
    private Reference _reference;
    private List<Word> _content;
    private Random _rng;

    // Function required by Library class
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
        result += ": ";
        foreach (Word word in _content)
        {
            result += word.RenderString();
            result += " ";
        }
        return result;
    }

    public void HideMore()
    {   
        // Hide 8 verses each time - this may attempt to hide
        // words that have already been hidden
        for (int i = 0; i < 8; i += 1)
        {
            int idx = _rng.Next(_content.Count);
            _content[idx].Hide();
        }
    }
}