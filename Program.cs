using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruce ATM homework
{
    internal class Program
    {
    //***************** Global Variables  ***********************




    // our allow user input options 
    public static string[] menuOptions = { "1", "2", "3", "4" };



    //user ballancve funds
    public static decimal balance;


    private static void CheckPin()
    {
        string pin = "";
        Console.WriteLine("\t ***** Welcome to the ATM Program  ***** \n\n \t Please enter your pin number");

        //ask user input
        pin= Console.ReadLine();

        //use while loop to check pin 

        while(pin != "1234")
        {
            if (pin == "1234")
            {
                break;
            }

            else
            {
                Console.WriteLine("\t pin number incorrect enter again");
                pin = Console.ReadLine();
            }
        }

        Console.WriteLine("\t Pin correct Access Granted.");
        MainMenu();

    } //end check pin 


    //create main menu function

    static void MainMenu()
    {
        Console.WriteLine("\t**********************************************\n");

        Console.WriteLine("\t Select an option:\n");
        Console.WriteLine("\t [1] View Balance");
        Console.WriteLine("\t [2] Withdraw Funds");
        Console.WriteLine("\t [3] Deposit Funds");
        Console.WriteLine("\t [4] Exit Application \n");

        Console.WriteLine("\t**********************************************");





    }

        static void Main(string[] args)
        {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
           

