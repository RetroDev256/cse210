// This class stores information about a journal entry,
// and can format the journal entry as a string

[Serializable]
class Entry
{
    // C# JSON serialization requires get and set methods for each attribute
    public string _date { get; set; }
    public string _question { get; set; }
    public string _answer { get; set; }

    // C# requires these parameters to share the same names
    // as the attributes for JSON serialization to work
    public Entry(string _date, string _question, string _answer)
    {
        this._date = _date;
        this._question = _question;
        this._answer = _answer;
    }

    public string Format()
    {
        return $"Date: {_date}\nQuestion: {_question}\nAnswer: {_answer}\n";
    }
}
