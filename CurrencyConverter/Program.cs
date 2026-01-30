using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Currency Converter");
        Console.WriteLine("1. INR to USD");
        Console.WriteLine("2. USD to INR");
        Console.WriteLine("3. USD to Euro");
        Console.WriteLine("4. Euro to INR");
        Console.WriteLine("5. Frank to INR");
        Console.WriteLine("6. INR to Frank");
        Console.Write("\nSelect conversion (1-6): ");

        int choice = int.Parse(Console.ReadLine());        
        int usdtoinr = 92;
        int eurotoinr = 100;
        int franktoinr = 101;
        int amount, converted;
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter Amount in INR:");
                amount = int.Parse((Console.ReadLine()));
                converted = amount / usdtoinr;
                Console.WriteLine("Amount in USD: " + converted);
                break;

            case 2:
                Console.WriteLine("Enter Amount in USD:");  
                amount = int.Parse((Console.ReadLine()));
                converted = amount * usdtoinr;  
                Console.WriteLine("Amount in INR: " + converted);
                break;
            
            case 3:
                Console.WriteLine("Enter Amount in USD:");
                amount = int.Parse((Console.ReadLine()));
                converted = amount * eurotoinr / usdtoinr;
                Console.WriteLine("Amount in Euro: " + converted);
                break;
            
            case 4:
                Console.WriteLine("Enter Amount in Euro:");
                amount = int.Parse((Console.ReadLine()));
                converted = amount * eurotoinr;
                Console.WriteLine("Amount in INR: " + converted);
                break;

            case 5:
                Console.WriteLine("Enter Amount in Frank:");
                amount = int.Parse((Console.ReadLine()));
                converted = amount * franktoinr;
                Console.WriteLine("Amount in INR: " + converted);
                break;

            case 6: 
                Console.WriteLine("Enter Amount in INR:");
                amount = int.Parse((Console.ReadLine()));
                converted = amount / franktoinr;
                Console.WriteLine("Amount in Frank: " + converted);
                break;


            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        

        
        
    }
}