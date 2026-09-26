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
            Console.WriteLine($"ID: {e.ID}");
            Console.WriteLine($"Title: {e.Title}");
            Console.WriteLine($"Category: {e.Category}");
            Console.WriteLine($"Amount: {e.Amount}");
            Console.WriteLine($"Date: {e.Date}");
            Console.WriteLine();
        }
    
    }
    public void SearchExpense()
    {
        Console.WriteLine("Enter the category you want to search");
        string category =  Console.ReadLine();
        Console.WriteLine();
        bool found = false;
        foreach (Expense c in expenses)
        {
            if(c.Category == category ) 
            {
                Console.WriteLine($"ID: {c.ID}");
                Console.WriteLine($"Title: {c.Title}");
                Console.WriteLine($"Category: {c.Category}");
                Console.WriteLine($"Amount: {c.Amount}");
                Console.WriteLine($"Date: {c.Date}");
                Console.WriteLine();
                found = true;
            }
        }
        if (found == false) 
        {
            Console.WriteLine("There is no category");
        }
    }
    public void DeleteExpenses()
    {
        Console.WriteLine("Enter the Id you want to Delete");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Expense foundExpense = null;
        bool idfound = false;
        foreach(Expense i in expenses)
        {
            if(i.ID == id) 
            {
                foundExpense = i;
                Console.WriteLine($"Your id is {i.ID} was deleted");
                idfound = true;
                break;
            }
        }
        if(foundExpense != null)
        {
            expenses.Remove(foundExpense);
        }
        if(idfound == false)
        {
            Console.WriteLine("There is no ID");
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
                    Console.WriteLine("Add Expense Selected");
                    exp.AddExpenses();
                        break;

                    case 2:
                    Console.WriteLine();
                    Console.WriteLine("View Expense Selected");
                    exp.ViewExpenses();
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Search Expense Selected");
                        exp.SearchExpense();
                    break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Delete Expense Selected");
                        exp.DeleteExpenses();
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