class Breathing : BaseActivity
{
    public Breathing(string description) : base("Breathing", description)
    {
        
    }

    public void Run()
    {
        DisplayStartMessage();
        RunCountDown("Breathe in...");
        RunCountDown("Hold...");
        RunCountDown("Breathe out...");
        DisplayEndMessage();
    }
}