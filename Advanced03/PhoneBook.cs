namespace Advanced03;

public static class PhoneBook
{
    public static void Run ()
    {
        Dictionary<string, string> phoneBook = new();
        phoneBook.Add("Mona", "01000");
        phoneBook.Add("Ahmed", "010000");
        phoneBook.Add("Ali", "0100");
        phoneBook.Add("Oumar", "0199");

        #region Add a new contact using [] syntax
        phoneBook["Fatma"] = "0105555";
        #endregion

        #region Try adding a duplicate using .Add()
        try
        {
            phoneBook.Add("Mona", "01000");
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine("Mona's number already exists!");
            Console.WriteLine(ex.Message);
        }
        #endregion

        #region Try adding a duplicate using .TryAdd()
        if(phoneBook.TryAdd("Mona", "01000"))
            Console.WriteLine("Mona was added");
        else
            Console.WriteLine("Mona already exists!");
        #endregion

        #region Search for a contact that doesn’t 
        if (phoneBook.ContainsKey("Sara"))
            Console.WriteLine(phoneBook["Sara"]);
        else
            Console.WriteLine("Sara dose not exist");
        #endregion

        #region Get a contact with a fallback of "Not Found"
        Console.WriteLine(phoneBook.GetValueOrDefault("Sara", "Not Found"));
        #endregion

        #region Print all Keys on one line, then all Values on another line
        Console.WriteLine($"Names: {string.Join(" , ",phoneBook.Keys)}");
        Console.WriteLine($"Numbers: {string.Join(" , ",phoneBook.Values)}");
        #endregion

    }
}
