namespace Advanced03;

public static class PrintQueueSimulator
{
    public static void Run()
    {
        Queue<string> printQueue = new();
        printQueue.Enqueue("Report.pdf");
        printQueue.Enqueue("Invoice.pdf");
        printQueue.Enqueue("Letter.docx");
        printQueue.Enqueue("Resume.pdf");
        printQueue.Enqueue("Photo.jpg");

        #region Print the queue contents and Count
        foreach (string file in printQueue)
            Console.WriteLine(file);
        Console.WriteLine(printQueue.Count);
        #endregion

        #region Use Peek
        Console.WriteLine(printQueue.Peek());
        //out put : Report.pdf --> FIFO (First In First Out)
        #endregion

        #region Dequeue each document and print
        while (printQueue.Count > 0)
        {
            string file = printQueue.Dequeue();
            Console.WriteLine($"Printing: {file}");
        }
        #endregion

        #region Try TryDequeue 
        if (printQueue.TryDequeue(out string? value))
            Console.WriteLine(value);
        else
            Console.WriteLine("The queue is empty.");
        #endregion

    }
}
