class Breathing : Activity
{
    public Breathing(int duration) : base("breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration) { }

    public void RunBreathing()
    {
        StartMessage();

        int delay = _duration;
        while (delay > 0)
        {
            CountDown("Breathe in...", 5);
            CountDown("Breathe out...", 3);
            delay -= 8;
        }
        
        EndMessage();
    }
}