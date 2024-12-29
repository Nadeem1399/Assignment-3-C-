using System;

class Employee
{
    // Constants for tax rates and commission percentage
    private const double FederalTaxRate = 0.18;
    private const double RetirementContributionRate = 0.10;
    private const double SocialSecurityTaxRate = 0.06;
    private const double CommissionPercentage = 0.07;

    // Properties
    public string Name { get; set; }
    public double SalesAmount { get; set; }

    // Constructor
    public Employee(string name, double salesAmount)
    {
        Name = name;
        SalesAmount = salesAmount;
    }

    // Method to calculate commission income
    public double CalculateCommissionIncome()
    {
        return SalesAmount * CommissionPercentage;
    }

    // Method to calculate federal tax withholding amount
    public double CalculateFederalTax()
    {
        return SalesAmount * FederalTaxRate;
    }

    // Method to calculate social security tax withholding amount
    public double CalculateSocialSecurityTax()
    {
        return SalesAmount * SocialSecurityTaxRate;
    }

    // Method to calculate retirement contribution amount
    public double CalculateRetirementContribution()
    {
        return SalesAmount * RetirementContributionRate;
    }

    // Method to calculate take-home pay
    public double CalculateTakeHomePay()
    {
        double totalEarnings = SalesAmount + CalculateCommissionIncome();
        double totalDeductions = CalculateFederalTax() + CalculateSocialSecurityTax() + CalculateRetirementContribution();
        return totalEarnings - totalDeductions;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter employee name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter sales amount for the week:");
        double salesAmount = Convert.ToDouble(Console.ReadLine());

        Employee employee = new Employee(name, salesAmount);

        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine("Name: " + employee.Name);
        Console.WriteLine("Sales Amount: " + employee.SalesAmount.ToString("C"));

        Console.WriteLine("\nCalculations:");
        Console.WriteLine("Commission Income: " + employee.CalculateCommissionIncome().ToString("C"));
        Console.WriteLine("Federal Tax Withholding: " + employee.CalculateFederalTax().ToString("C"));
        Console.WriteLine("Social Security Tax Withholding: " + employee.CalculateSocialSecurityTax().ToString("C"));
        Console.WriteLine("Retirement Contribution: " + employee.CalculateRetirementContribution().ToString("C"));

        Console.WriteLine("\nTake-Home Pay: " + employee.CalculateTakeHomePay().ToString("C"));

        Console.ReadLine(); // To keep console window open
    }
}