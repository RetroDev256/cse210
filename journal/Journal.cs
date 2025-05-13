// This class manages journal entries - it will load entries,
// save entries, add new entries, and format all entries as a string

using System.Text.Json;

class Journal
{
    List<Entry> entries = new List<Entry>();

    public void addEntry(Entry entry)
    {
        this.entries.Add(entry);
    }

    public string getEntries()
    {
        string result = "";
        foreach (Entry entry in this.entries)
        {
            result += entry.format() + '\n';
        }
        return result;
    }

    // STRETCH CHALLENGE: Saving file as JSON so
    // other programs can interact with our journal
    public void loadEntries(string path)
    {
        string json = File.ReadAllText(path);
        this.entries = JsonSerializer.Deserialize<List<Entry>>(json)!;
    }

    // STRETCH CHALLENGE: Loading file as JSON so
    // other programs can interact with our journal
    public void saveEntries(string path)
    {
        string json = JsonSerializer.Serialize<List<Entry>>(this.entries);
        File.WriteAllText(path, json);
    }
}