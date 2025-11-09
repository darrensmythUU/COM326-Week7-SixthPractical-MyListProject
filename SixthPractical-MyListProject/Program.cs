class Program
{
    public static void Main(string[] args)
    {
        // Task 2 Beginning
        List<string> months = new List<string>();

        // Task 3 Beginning
        Console.WriteLine("---------------------------");
        Console.WriteLine("Task 3");
        Console.WriteLine("---------------------------");

        months.Add("January");
        months.Add("February");
        months.Add("March");
        months.Add("April");
        months.Add("May");
        months.Add("June");
        months.Add("July");
        months.Add("August");
        months.Add("September");
        months.Add("October");
        months.Add("November");
        months.Add("December");

        foreach (string month in months)
        {
            Console.WriteLine(month);
        }

        // Task 4 Beginning
        Console.WriteLine("");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Task 4");
        Console.WriteLine("---------------------------");

        string[] monthNames = months.ToArray();

        for (int i = 0; i < monthNames.Length; i++)
        {
            Console.WriteLine(monthNames[i]);
        }

        // Task 5 Beginning
        Console.WriteLine("");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Task 5");
        Console.WriteLine("---------------------------");

        Console.WriteLine($"The length of the months list before removing the requested objects is: {months.Count}.");
        months.Remove("September");
        months.Remove("November");
        Console.WriteLine($"The length of the months list after removing the requested objects is: {months.Count}.");
    }
}