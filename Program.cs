using System;

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
class Program
{
    
    List<Expense> expenses = new List<Expense>();
    public void AddExpenses()
    {
        Console.WriteLine("Enter the ID");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Title");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the category");
        string category = Console.ReadLine();
        Console.WriteLine("Enter the Amount");
        double amount = Convert.ToDouble(Console.ReadLine());
        DateTime date = DateTime.Now;

        //Create object to call constructor
        Expense expen = new Expense(id, title, category, amount, date);
        expenses.Add(expen);
    }
    public void ViewExpenses() 
    {
        foreach (Expense e in expenses)
        {
            Console.WriteLine($"ID: {e.ID}, Title: {e.Title}, Category: {e.Category}, Amount: {e.Amount}, Date: {e.Date}");
        }
    
    }
    static void Main(string[] args) 
    {
        Program exp = new Program();
        while (true) 
        {
            Console.WriteLine();
            Console.WriteLine("===== Expense Tracker =====");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View Expenses");
            Console.WriteLine("3. Search Expense");
            Console.WriteLine("4. Delete Expense");
            Console.WriteLine("5. Total Expenses");
            Console.WriteLine("6. Monthly Expenses");
            Console.WriteLine("7. Exit");

            Console.WriteLine("Enter your choice: ");
            int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice) 
                {
                    case 1:
                        exp.AddExpenses();
                        break;

                    case 2:
                        exp.ViewExpenses();
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        Console.WriteLine("Thank you for using Expense Tracker.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;

            }
            
        }
    }
}