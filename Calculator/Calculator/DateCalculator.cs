using System;

public class DateCalculator
{
    public void PerformOneDateCalculation()
    {
        AddDaysOnToDate();
    }
    private void AddDaysOnToDate()
    {
        Console.WriteLine("What date would you like to add days to? (##/##/####)");
        DateTime givenDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("How many days would you like to add on?");
        int daysAdding = int.Parse(Console.ReadLine());
        DateTime resultingDate = givenDate.AddDays(daysAdding);
        Console.WriteLine("The intial date was {0} and with {1} added on the new date is {2}.",
            givenDate.ToShortDateString(),
            daysAdding,
            resultingDate.ToShortDateString());
        Console.ReadLine();

    }

}
