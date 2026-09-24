using System;

class Expense
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Category { get; set; }
    public double Amount { get; set; }
    public DateTime Date { get; set; }

    public Expense(int id, string title, string category, double amount, int date)
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
    static void Main(string[] args) 
    {
    }
}