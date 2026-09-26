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
    int nextid = 1;
    public void AddExpenses()
    {
        Console.WriteLine("Enter the Title");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the category");
        string category = Console.ReadLine();
        
        double amount;
        while (true) 
        {
            Console.WriteLine("Enter the Amount");
            if (double.TryParse(Console.ReadLine(), out amount))
            {
                if (amount > 0)
                {
                    break;
                }
                Console.WriteLine("Initial Amount Cannot Be Negative");
            }
            else
            {
                Console.WriteLine("Please enter a valid number for Amount");
            }

        }
        
        DateTime date = DateTime.Now;

        //Create object to call constructor
        Expense expen = new Expense(nextid,title, category, amount, date);
        expenses.Add(expen);
        nextid++;
        
    }
    public void DisplayExpense(Expense e)
    {
        Console.WriteLine($"ID: {e.ID}");
        Console.WriteLine($"Title: {e.Title}");
        Console.WriteLine($"Category: {e.Category}");
        Console.WriteLine($"Amount: {e.Amount:N2}");
        Console.WriteLine($"Date: {e.Date:dd-MM-yyyy}");
    }
    public void ViewExpenses() 
    {
        if(expenses.Count == 0) 
        { 
            Console.WriteLine("No expenses found.");
            return;
        }
        
        foreach (Expense e in expenses)
        {
            DisplayExpense(e);
            Console.WriteLine();
        }
    
    }
    public void SearchExpense()
    {
        if (expenses.Count == 0) 
        {
            Console.WriteLine("No expenses found");
            return;
        }
        Console.WriteLine("Enter the category you want to search");
        string category =  Console.ReadLine();
        Console.WriteLine();
        bool found = false;
        foreach (Expense c in expenses)
        {
            if(string.Equals(c.Category, category, StringComparison.OrdinalIgnoreCase)) 
            {
                DisplayExpense(c);
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
        if(expenses.Count == 0)
        {
            Console.WriteLine("No expenses found.");
            return;
        }
        int id;
        while (true) 
        {
            Console.WriteLine("Enter the Id you want to Delete");
            if(int.TryParse(Console.ReadLine(), out id)) 
            { 
                if(id > 0)
                {
                    break;
                }
                Console.WriteLine("Initial ID Cannot Be Negative");
            }
            Console.WriteLine("Please enter the Valid Id number");
        }
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
    public void TotalExpense()
    {
        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses found.");
            return;
        }

        double total = 0;
        foreach(Expense t in expenses)
        {
            total += t.Amount;
        }
        Console.WriteLine($"Total Amount is {total:N2}");

    }
    public void MonthlyExpense()
    {
        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses found.");
            return;
        }

        int month;
        while (true)
        {
            Console.WriteLine("Enter the month" );
            if(int.TryParse(Console.ReadLine(), out month))
            {
                if(month >= 1 && month <= 12) 
                {
                    break;
                }
                Console.WriteLine("Month must be between 1 and 12.");
            }
            Console.WriteLine("Please enter the Valid Month number");
        }
        Console.WriteLine();

        int year;
        while (true)
        {
            Console.WriteLine("Enter the year");
            if (int.TryParse(Console.ReadLine(), out year))
            {
                if (year > 0)
                {
                    break;
                }
                Console.WriteLine("Year must be greater than 0");
            }
            Console.WriteLine("Please enter a valid year.");
        }
        Console.WriteLine();

        double Totality = 0;
        foreach (Expense tot in expenses) 
        { 
            if(month == tot.Date.Month && year == tot.Date.Year) 
            {
                Totality += tot.Amount;
            }
        }
        Console.WriteLine($"Total Monthly expense is {Totality:N2}");
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

            int Choice;
            while (true)
            {
                Console.WriteLine("Enter your choice: 1 to 7 ");
                if (int.TryParse(Console.ReadLine(), out Choice))
                {
                    if (Choice >= 1 && Choice >=7)
                    {
                        break;
                    }
                    Console.WriteLine("Initial Choice number Cannot Be zero or negative");
                }
                Console.WriteLine("Please Enter the valid choice number");
            }
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
                     Console.WriteLine();
                     Console.WriteLine("Total Expense Selected");
                      exp.TotalExpense();
                break;

                case 6:
                     Console.WriteLine();
                     Console.WriteLine("Monthly Expense Selected");
                      exp.MonthlyExpense();
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