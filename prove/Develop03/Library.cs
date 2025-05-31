// Exceeding Requirements - Program stores a library of scriptures and picks them at random.

public class Library
{
    static private List<Scripture> _scriptures = [
        new Scripture(new Reference("1 Nephi", 1, 1, 1),
            SplitWords("I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.")
        ),
        new Scripture(new Reference("3 Nephi", 3, 7, 7),
            SplitWords("Or in other words, yield yourselves up unto us, and unite with us and become acquainted with our secret works, and become our brethren that ye may be like unto us—not our slaves, but our brethren and partners of all our substance.")
        ),
        new Scripture(new Reference("Ether", 12, 27, 27),
            SplitWords("And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.")
        ),
        new Scripture(new Reference("Alma", 5, 26, 27),
            SplitWords("And now behold, I say unto you, my brethren, if ye have experienced a change of heart, and if ye have felt to sing the song of redeeming love, I would ask, can ye feel so now? Have ye walked, keeping yourselves blameless before God? Could ye say, if ye were called to die at this time, within yourselves, that ye have been sufficiently humble? That your garments have been cleansed and made white through the blood of Christ, who will come to redeem his people from their sins?")
        ),
        new Scripture(new Reference("Alma", 12, 38, 40),
            SplitWords("Now Zeezrom saith again unto him: Is the Son of God the very Eternal Father? And Amulek said unto him: Yea, he is the very Eternal Father of heaven and of earth, and all things which in them are; he is the beginning and the end, the first and the last; And he shall come into the world to redeem his people; and he shall take upon him the transgressions of those who believe on his name; and these are they that shall have eternal life, and salvation cometh to none else.")
        )
    ];
    static private Random _rng = new Random();

    // This can be improved at some point to construct the scriptures inside the
    // function, so we don't get references to functions, but our own instances.
    public static Scripture GetRandom()
    {
        int idx = _rng.Next(_scriptures.Count);
        return _scriptures[idx];
    }

    // Construct a list of words from a string, split by spaces.
    private static List<Word> SplitWords(string text)
    {
        List<Word> words = new List<Word>();
        foreach (string part in text.Split(' '))
        {
            words.Add(new Word(part));
        }
        return words;
    }
}