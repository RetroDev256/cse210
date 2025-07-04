// Representing the score of a player on the scoreboard
public class Score
{
    private int _value;
    private string _date;
    private string _name;

    public Score(int value, string date, string name)
    {
        _value = value;
        _date = date;
        _name = name;
    }

    // This function deserializes some Score from an encoded string
    // Each Score is stored as 3 space delimited base64 values
    public Score(string encoded)
    {
        string[] encoded_parts = encoded.Split(' ');

        byte[] val_bytes = System.Convert.FromBase64String(encoded_parts[0]);
        byte[] date_bytes = System.Convert.FromBase64String(encoded_parts[1]);
        byte[] name_bytes = System.Convert.FromBase64String(encoded_parts[2]);

        _value = int.Parse(System.Text.Encoding.UTF8.GetString(val_bytes));
        _date = System.Text.Encoding.UTF8.GetString(date_bytes);
        _name = System.Text.Encoding.UTF8.GetString(name_bytes);
    }

    // Used for comparisons
    public int GetValue()
    {
        return _value;
    }

    public string Format()
    {
        // The ,7 here pads _value to 7 characters
        return $"{_value,7} - {_date} - {_name}";
    }

    // This function encodes the state of Score as a string
    // Each Score is stored as 3 space delimited base64 values
    public string Serialize()
    {
        byte[] val_bytes = System.Text.Encoding.UTF8.GetBytes($"{_value}");
        byte[] date_bytes = System.Text.Encoding.UTF8.GetBytes(_date);
        byte[] name_bytes = System.Text.Encoding.UTF8.GetBytes(_name);

        string encoded_val = System.Convert.ToBase64String(val_bytes);
        string encoded_date = System.Convert.ToBase64String(date_bytes);
        string encoded_name = System.Convert.ToBase64String(name_bytes);

        return $"{encoded_val} {encoded_date} {encoded_name}";
    }
}