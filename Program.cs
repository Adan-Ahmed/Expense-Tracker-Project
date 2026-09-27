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
    int nextId = 1;
    public void AddExpense()
    {
        string title = GetTitle();
        //while (true) 
        //{
        //    Console.WriteLine("Enter the Title");
        //    title = Console.ReadLine();
        //    if (String.IsNullOrWhiteSpace(title)) 
        //    {
        //        Console.WriteLine("Title cannot be empty.");
        //    }
        //    else 
        //    {
        //        break;
        //    }
        //}
        string category = GetCategory();
        //while (true)
        //{
        //    Console.WriteLine("Enter the category");
        //    category = Console.ReadLine();
        //    if (String.IsNullOrWhiteSpace(category))
        //    {
        //        Console.WriteLine("category cannot be empty.");
        //    }
        //    else
        //    {
        //        break;
        //    }
        //}

        double amount = GetAmount();
        //while (true) 
        //{
        //    Console.WriteLine("Enter the Amount");
        //    if (double.TryParse(Console.ReadLine(), out amount))
        //    {
        //        if (amount > 0)
        //        {
        //            break;
        //        }
        //        Console.WriteLine("Amount must be greater than 0.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please enter a valid number for Amount");
        //    }

        //}
        
        DateTime date = DateTime.Now;

        //Create object to call constructor
        Expense expen = new Expense(nextId,title, category, amount, date);
        expenses.Add(expen);
        nextId++;
        
    }
    public void DisplayExpense(Expense e)
    {
        Console.WriteLine($"ID: {e.ID}");
        Console.WriteLine($"Title: {e.Title}");
        Console.WriteLine($"Category: {e.Category}");
        Console.WriteLine($"Amount: {e.Amount:N2}");
        Console.WriteLine($"Date: {e.Date:dd-MM-yyyy}");
    }

    public string GetCategory() 
    {
        string category;
        while (true)
        {
            Console.WriteLine("Enter the category");
            category = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(category))
            {
                Console.WriteLine("category cannot be empty.");
            }
            else
            {
                break;
            }
        }
        return category;
    }
    public string GetTitle()
    {
        string title;
        while (true)
        {
            Console.WriteLine("Enter the Title");
            title = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Title cannot be empty.");
            }
            else
            {
                break;
            }
        }
        return title;
    }
    public double GetAmount()
    {
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
                Console.WriteLine("Amount must be greater than 0.");
            }
            else
            {
                Console.WriteLine("Please enter a valid number for Amount");
            }

        }
        return amount;
    }
    public int GetID() 
    {
        int id;
        while (true)
        {
            Console.WriteLine("Enter the ID you want to Delete");
            if (int.TryParse(Console.ReadLine(), out id))
            {
                if (id > 0)
                {
                    break;
                }
                Console.WriteLine("ID must be greater than 0.");
            }
            else
            {
                Console.WriteLine("Please enter the Valid ID number");
            }
        }
        return id;
    }
    public int GetMonth() 
    {
        int month;
        while (true)
        {
            Console.WriteLine("Enter the month");
            if (int.TryParse(Console.ReadLine(), out month))
            {
                if (month >= 1 && month <= 12)
                {
                    break;
                }
                Console.WriteLine("Month must be between 1 and 12.");
            }
            else
            {
                Console.WriteLine("Please enter the Valid Month number");
            }
        }
        return month;
    }

    public int GetYear() 
    {
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
                Console.WriteLine("Year must be Greater than 0");
            }
            else
            {
                Console.WriteLine("Please enter a Valid year.");
            }
        }
        return year;
    }
    public int GetChoice()
    {
        int choice;

        while (true)
        {
            Console.WriteLine("Enter your choice: 1 to 7");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice >= 1 && choice <= 7)
                {
                    break;
                }

                Console.WriteLine("Choice must be between 1 and 7.");
            }
            else
            {
                Console.WriteLine("Please enter a valid choice number.");
            }
        }

        return choice;
    }
    public void ViewExpenses() 
    {
        if(expenses.Count == 0) 
        { 
            Console.WriteLine("No expenses found.");
            return;
        }
        
        foreach (Expense expense in expenses)
        {
            DisplayExpense(expense);
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
        //string category;
        //while (true)
        //{
        //    Console.WriteLine("Enter the category you want to search");
        //    category = Console.ReadLine();
        //    if (String.IsNullOrWhiteSpace(category))
        //    {
        //        Console.WriteLine("Category cannot be empty.");
        //    }
        //    else
        //    {
        //        break;
        //    }
        //}
        string category = GetCategory();

        bool found = false;
        foreach (Expense expense in expenses)
        {
            if(string.Equals(expense.Category, category, StringComparison.OrdinalIgnoreCase)) 
            {
                DisplayExpense(expense);
                Console.WriteLine();
                found = true;
            }
        }
        //if (found == false) 
        //We can used like this
        if (!found)
        {
            Console.WriteLine("No expense found for that category.");
        }
    }
    public void DeleteExpense()
    {
        if(expenses.Count == 0)
        {
            Console.WriteLine("No expenses found.");
            return;
        }

        int id = GetID();
        //while (true) 
        //{
        //    Console.WriteLine("Enter the ID you want to Delete");
        //    if(int.TryParse(Console.ReadLine(), out id)) 
        //    { 
        //        if(id > 0)
        //        {
        //            break;
        //        }
        //        Console.WriteLine("ID must be greater than 0.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please enter the Valid ID number");
        //    }
        //}
        Console.WriteLine();
        Expense foundExpense = null;
        foreach(Expense expense in expenses)
        {
            if(expense.ID == id) 
            {
                foundExpense = expense;
                break;
            }
        }
        if(foundExpense != null)
        {
            expenses.Remove(foundExpense);
            Console.WriteLine($"Expense with ID {foundExpense.ID} was deleted.");
        }
        else
        {
            Console.WriteLine("No expense found with that ID");
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
        foreach(Expense expense in expenses)
        {
            total += expense.Amount;
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

        int month = GetMonth();
        //while (true)
        //{
        //    Console.WriteLine("Enter the month" );
        //    if(int.TryParse(Console.ReadLine(), out month))
        //    {
        //        if(month >= 1 && month <= 12) 
        //        {
        //            break;
        //        }
        //        Console.WriteLine("Month must be between 1 and 12.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please enter the Valid Month number");
        //    }
        //}
        Console.WriteLine();

        int year = GetYear();
        //while (true)
        //{
        //    Console.WriteLine("Enter the year");
        //    if (int.TryParse(Console.ReadLine(), out year))
        //    {
        //        if (year > 0)
        //        {
        //            break;
        //        }
        //        Console.WriteLine("Year must be Greater than 0");
        //    }
        //    else 
        //    { 
        //        Console.WriteLine("Please enter a Valid year.");
        //    }
        //}
        Console.WriteLine();

        double total = 0;
        foreach (Expense expense in expenses) 
        { 
            if(month == expense.Date.Month && year == expense.Date.Year) 
            {
                total += expense.Amount;
            }
        }
        Console.WriteLine($"Total Monthly expense is {total:N2}");
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

            int choice = exp.GetChoice();
            //while (true)
            //{
            //    Console.WriteLine("Enter your choice: 1 to 7 ");
            //    if (int.TryParse(Console.ReadLine(), out choice))
            //    {
            //        if (choice >= 1 && choice <= 7)
            //        {
            //            break;
            //        }
            //        Console.WriteLine("Choice must be between 1 and 7.");
            //    }
            //    Console.WriteLine("Please Enter the valid choice number");
            //}
            switch (choice) 
                {
                case 1:
                    Console.WriteLine("Add Expense Selected");
                    exp.AddExpense();
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
                     exp.DeleteExpense();
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

                }
        }
    }
}