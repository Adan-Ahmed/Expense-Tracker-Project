using System;
using System.Security.Cryptography.X509Certificates;

class Expense
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Category { get; set; }
    public double Amount { get; set; }
    public DateTime Date { get; set; }

    public Expense(int id, string title, string category, double amount, DateTime date)
    {
        ID = id;
        Title = title;
        Category = category;
        Amount = amount;
        Date = date;
    }

}

class main
{
    public void AddExpense()
    {
        Console.WriteLine("Enter the ID");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Title");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the category");
        string category = Console.ReadLine();
        Console.WriteLine("Enter the Amount");
        double amount = Convert.ToDouble(Console.ReadLine());
        DateTime date = DateTime.Today;

        Expense expense = new Expense(1, "Lunch", "Food", 500, date);

    }
    static void Main(string[] args) 
    {
        List<Expense> expenses = new List<Expense>();
        DateTime date = DateTime.Now;
        Expense exp = new Expense(1, "Lunch", "Food", 500, date);
        expenses.Add(exp);
        foreach (Expense e in expenses)
        {
            Console.WriteLine($"ID: {e.ID}, Title: {e.Title}, Category: {e.Category}, Amount: {e.Amount}, Date: {e.Date}");
        }
    }
}