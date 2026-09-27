# Expense Tracker

A simple C# console application for keeping track of daily expenses.

## Features

* Add a new expense
* View all expenses
* Search expenses by category
* Delete an expense using its ID
* Calculate total expenses
* Calculate expenses for a specific month and year
* Input validation for user entries
* Automatic ID for each expense
* Displays expense date and amount in a readable format

## Technologies Used

* C#
* .NET
* Visual Studio

## How It Works

When the program starts, it shows a menu with different options.

```text
===== Expense Tracker =====
1. Add Expense
2. View Expenses
3. Search Expense
4. Delete Expense
5. Total Expenses
6. Monthly Expenses
7. Exit
```

### Add Expense

The user enters:

* Title
* Category
* Amount

The program automatically creates an ID and saves the current date for the expense.

### View Expenses

Shows all saved expenses with their:

* ID
* Title
* Category
* Amount
* Date

### Search Expense

The user enters a category, and the program shows expenses that match that category.

The category search is not case-sensitive.

### Delete Expense

The user enters an expense ID. If the ID exists, that expense is removed from the list.

### Total Expenses

Adds the amount of all saved expenses and displays the total.

### Monthly Expenses

The user enters a month and year. The program calculates the total expenses for that month.

## Input Validation

The program checks user input before accepting it.

For example:

* Title and category cannot be empty.
* Amount must be greater than 0.
* Expense ID must be a valid positive number.
* Month must be between 1 and 12.
* Year must be greater than 0.
* Menu choice must be between 1 and 7.

## Project Structure

The project mainly contains two classes:

### Expense

Stores the information about an expense:

```text
ID
Title
Category
Amount
Date
```

### Program

Contains the menu and methods for adding, viewing, searching, deleting, and calculating expenses.

## How to Run

1. Open the project in Visual Studio.
2. Build the project.
3. Run the application.
4. Select an option from the menu.
5. Follow the instructions shown in the console.

## What I Practiced

This project helped me practice:

* Classes and objects
* Constructors
* Properties
* Lists
* Methods
* Loops
* Conditions
* Switch statements
* Input validation
* `TryParse`
* `DateTime`
* Searching and deleting items from a list

## Note

This is a console-based practice project. The expenses are stored in a list while the program is running, so the data is cleared when the application is closed.
