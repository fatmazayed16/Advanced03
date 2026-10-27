namespace Advanced03;

public static class UniqueEmailValidator
{
    public static void Run()
    {
        HashSet<string> emails = new(StringComparer.OrdinalIgnoreCase);
        emails.Add("ahmed@test.com");
        emails.Add("AHMED@test.com");
        emails.Add("sara@test.com");
        emails.Add("Sara@Test.Com");

        #region Print Count 
        Console.WriteLine(emails.Count);
        //Count = 2 because HashSet uses StringComparer.OrdinalIgnoreCase,which treats uppercase and lowercase emails as equal and prevents duplicates.
        #endregion

        #region Create two sets
        HashSet<int> setA = new() { 1, 2, 3, 4, 5};
        HashSet<int> setB = new() { 4, 5, 6, 7, 8};
        #endregion

        #region UnionWith
        HashSet<int> setACopy01 = new(setA);
        setACopy01.UnionWith(setB);
        Console.WriteLine("-----------UnionWith----------");

        foreach (int num in setACopy01)
        {
            Console.WriteLine(num);
        }
        #endregion

        #region IntersectWith
        HashSet<int> setACopy02 = new(setA);
        setACopy02.IntersectWith(setB);
        Console.WriteLine("-----------IntersectWith----------");
        foreach (int num in setACopy02)
        {
            Console.WriteLine(num);
        }
        #endregion

        #region ExceptWith
        HashSet<int> setACopy03 = new(setA);
        setACopy03.ExceptWith(setB);
        Console.WriteLine("-----------ExceptWith----------");
        foreach (int num in setACopy03)
        {
            Console.WriteLine(num);
        }
        #endregion

        #region IsSubsetOf 
        HashSet<int> setC = new() { 1 ,2 };
        Console.WriteLine(setC.IsSubsetOf(setA));
        #endregion
    }
}
