using System.Diagnostics;

public class Reference
{
    // Prevent the member variables from being accessed outside of methods
    private string _book;
    private int _chapter;
    private int _start_verse;
    private int _end_verse;

    public Reference(string book, int chapter, int start_verse, int end_verse)
    {
        // Ensure the range of verses is valid
        Debug.Assert(end_verse >= start_verse);

        _book = book;
        _chapter = chapter;
        _start_verse = start_verse;
        _end_verse = end_verse;
    }

    // Renders the reference differently if it's only one verse
    public string RenderString()
    {
        if (_end_verse > _start_verse)
        {
            return $"{_book} {_chapter}:{_start_verse}-{_end_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_start_verse}";
        }
    }
}