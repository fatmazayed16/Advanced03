namespace Advanced03;

public static class BrowserHistory
{
    public static void Run()
    {
        Stack<string> browserHistory = new();
        browserHistory.Push("google.com");
        browserHistory.Push("github.com");
        browserHistory.Push("stackoverflow.com");
        browserHistory.Push("youtube.com");
        browserHistory.Push("claude.ai");

        #region Use Peek
        Console.WriteLine(browserHistory.Peek());
        #endregion

        #region Press "back" 3 times using Pop 
        Console.WriteLine(browserHistory.Pop());
        Console.WriteLine(browserHistory.Pop());
        Console.WriteLine(browserHistory.Pop());
        #endregion

        #region Print the current page after going back
        Console.WriteLine(browserHistory.Peek());
        #endregion

        #region Try TryPop on an empty stack
        browserHistory.Pop();
        browserHistory.Pop();
        if (browserHistory.TryPop(out string? page))
            Console.WriteLine(page);
        else
            Console.WriteLine("Stack is Empty");
        #endregion
    }
}
