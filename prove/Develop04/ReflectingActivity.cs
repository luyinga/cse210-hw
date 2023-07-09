class ReflectingActivity : Activity
{
    private string answer;

    public ReflectingActivity()
    {
        this.SetActivityName("Reflecting Activity");
        this.SetDescription("This Activity will help you reflect on times in your life" + 
                             "when you have shown strengh and resilience this will help you" + 
                             "reconize the power you have and how you can use it in aspect of your life");

    }
    public void Run()
    {
         DisplayStartingMessage();
        int interval = GetDuration() / 6;
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine();
            Console.Write("Get ready...");
            ShowCountDown(interval);
            Console.WriteLine();
            Console.Write("consider the following prompt:");
            Console.WriteLine("---thing of a time when you did something really difficult---" + 
                              "You may begin in:");
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue");
            Console.WriteLine();
            ShowCountDown(interval);                  
            Console.WriteLine("Well done!!");
            ShowCountDown(interval);
            Console.WriteLine();
            Console.WriteLine("You have completed another 30 second of the breathing activity");
            ShowCountDown(interval);
            
        } 
        DisplayEndingMessage();
    }
}