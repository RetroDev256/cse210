// This class manages journal entries - it will load entries,
// save entries, add new entries, and format all entries as a string

using System.Text.Json;

class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public string GetEntries()
    {
        string result = "";
        for (int i = 0; i < _entries.Count; i += 1)
        {
            result += _entries[i].Format();
            if (i + 1 < _entries.Count)
            {
                result += '\n';
            }
        }
        return result;
    }

    // STRETCH CHALLENGE: Saving file as JSON so
    // other programs can interact with our journal
    public void LoadEntries(string path)
    {
        string json = File.ReadAllText(path);
        _entries = JsonSerializer.Deserialize<List<Entry>>(json)!;
    }

    // STRETCH CHALLENGE: Loading file as JSON so
    // other programs can interact with our journal
    public void SaveEntries(string path)
    {
        string json = JsonSerializer.Serialize<List<Entry>>(_entries);
        File.WriteAllText(path, json);
    }
}