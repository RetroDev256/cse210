class Sleeping : Activity
{
    public Sleeping(int duration) : base("sleeping", "This activity will help you gain valuable rest in these trying times.", duration) { }

    public void RunSleeping()
    {
        StartMessage();


        Console.WriteLine("   ()___                   ");
        Console.WriteLine("()//__/)_________________()");
        Console.WriteLine("||(___)//#/_/#/_/#/_/#()/||");
        Console.WriteLine("||----|#| |#|_|#|_|#|_|| ||");
        Console.WriteLine("||____|_|#|_|#|_|#|_|#||/||");
        Console.WriteLine("||    |#|_|#|_|#|_|#|_|| \n");
        CountDown("Sweet dreams!", _duration);

        for (int i = 0; i < 70; i += 1)
        {
            Console.Write("WAKE UP");
            for (int j = 0; j < i; j += 1) {
                Console.Write("!");
            }
            Console.WriteLine();
        }

        EndMessage();
    }
}