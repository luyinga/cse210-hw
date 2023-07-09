class ListeningActivity : Activity
{
    private string answer;

    public ListeningActivity()
    {
        this.SetActivityName("listening Activity");
        this.SetDescription("This Activity will help you reflect on the good things" + 
                             "in your life by having you list as many things as you can in certain area.");

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
            Console.Write("List as many responses as you can to the the following prompt:");
            Console.WriteLine("---When have you felt the holy ghost this month?---" + 
                              "You may begin in:");
            answer = Console.ReadLine();
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