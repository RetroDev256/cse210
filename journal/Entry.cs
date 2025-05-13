// This class stores information about a journal entry,
// and can format the journal entry as a string

[Serializable]
class Entry
{
    public string date { get; set; }
    public string question { get; set; }
    public string answer { get; set; }

    public Entry(string date, string question, string answer)
    {
        this.date = date;
        this.question = question;
        this.answer = answer;
    }

    public string format()
    {
        return $"Date: {date}\nQuestion: {question}\nAnswer:{answer}\n";
    }
}
