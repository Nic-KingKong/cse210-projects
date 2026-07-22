class Breathing : BaseActivity
{
    public Breathing(string description) : base("Breathing", description)
    {
        
    }

    public void Run()
    {
        DisplayStartMessage();

        int phaseDuration = _duration / 3;
        int remainder = _duration % 3;

        int breatheInDuration = phaseDuration + (remainder > 0 ? 1 : 0);
        remainder--;
        int holdDuration = phaseDuration + (remainder > 0 ? 1 : 0);
        remainder--;
        int breatheOutDuration = phaseDuration + (remainder > 0 ? 1 : 0);

        RunCountDown("Breathe in...", breatheInDuration);
        RunCountDown("Hold...", holdDuration);
        RunCountDown("Breathe out...", breatheOutDuration);
        DisplayEndMessage();
    }
}