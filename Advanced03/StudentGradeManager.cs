namespace Advanced03;

public static class StudentGradeManager
{
    public static void Run()
    {
        List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

        #region Print the collection, Count, first and last grade

        #region Print the collection
        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }
        #endregion

        #region Count
        Console.WriteLine($"Grades Count is : {grades.Count}");
        #endregion

        #region first and last grade
        Console.WriteLine($"First Grades is : {grades.First()}");
        Console.WriteLine($"First Grades is : {grades.FirstOrDefault()}");

        Console.WriteLine($"Last Grades is : {grades.Last()}");
        #endregion 
        
        #endregion

        #region Sort
        grades.Sort();
        foreach (int grade in grades)
        {
            
            Console.WriteLine(grade);
        }
        #endregion

        #region The first grade above 90
        Console.WriteLine($"the first grade above 90: {grades.FirstOrDefault(g => g > 90)}");
        #endregion

        #region failing grades
        List<int> failingGrades = grades.Where(g => g < 75).ToList();
        Console.WriteLine("\nGrades below 75:\n");
        foreach (int grade in failingGrades)
        {
            Console.WriteLine(grade);
        }
        #endregion

        #region Remove all failing grades
        grades.RemoveAll(g => g < 75);
        Console.WriteLine("\n Degrees above 75\n");
        foreach(int grade in grades)
        {
            Console.WriteLine(grade);
        }
        #endregion

        #region Check if any grade equals 100
        bool check = grades.Contains(100);
        Console.WriteLine(check);
        ///////Another Answer////////////
        bool check02 = grades.Any(g => g == 100);
        Console.WriteLine(check02);
        #endregion

        #region List String
        List<string> gradeStrings = grades.Select(g => $"Grade: {g}").ToList();
        foreach (string grade in gradeStrings)
        {
            Console.WriteLine(grade);
        } 
        #endregion
    }
}
    
