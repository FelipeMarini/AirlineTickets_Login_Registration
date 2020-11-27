using System;

namespace AirlineTickets_Login_and_Register_Purchase
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validpassword;
            int choice;
            int counter = 0;
            string answer;
            
            string[] names = new string [5];
            string[] origin = new string [5];
            string[] destiny = new string [5];
            string[] data = new string [5];

            
            
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" Welcome to Marini Airlines Ticket Registration System ");
            Console.WriteLine("-------------------------------------------------------");
            

            do {
            
            Console.WriteLine();
            Console.WriteLine("Please type in your password to access airline ticket system:\n");
            Console.WriteLine();
            string senha = Console.ReadLine();
            validpassword = PerformLogin(senha);
            
            } while (!validpassword);

            Console.WriteLine();
            Console.WriteLine("Welcome to Marini Airlines Ticket Registration Menu");
            Console.WriteLine();

            bool PerformLogin(string senha) {

                if(senha == "123456") {
                    
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Password accepted");
                    Console.ResetColor();
                    return true;
                
                    } else {
                    
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Password Denied");
                    Console.ResetColor();
                    return false; 
            
                    }
                }


            do
            {

                Console.WriteLine("Main Menu");
                Console.WriteLine();
                Console.WriteLine("Please choose an option below:\n");
                Console.WriteLine();
                Console.WriteLine("[1] Register Ticket");
                Console.WriteLine("[2] Show Registered Tickets");
                Console.WriteLine("[3] Exit Main Menu");
                Console.WriteLine();
                Console.Write("Option: ");
                
                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        
                        Console.WriteLine();
                        Console.WriteLine("Register Passenger");
                        
                    do {

                            if (counter < 5) {

                            Console.WriteLine();
                            Console.WriteLine($"Please type in Passenger {counter + 1} Name:\n");
                            names[counter] = Console.ReadLine();
                            Console.WriteLine();
                            
                            Console.WriteLine($"Please type in Destiny of Travel:\n");
                            destiny[counter] = Console.ReadLine();
                            Console.WriteLine();
                            
                            Console.WriteLine($"Please type in Origin of Travel:\n");
                            origin[counter] = Console.ReadLine();
                            Console.WriteLine();
                            
                            Console.WriteLine($"Please type in Data of Travel:\n");
                            data[counter] = Console.ReadLine();
                            Console.WriteLine();

                            counter ++;

                            } else {
                            
                            Console.WriteLine("Limit for Passenger Registration Exceeded");
                            break;
                                   
                                   }
                            
                            Console.WriteLine();
                            Console.WriteLine("Would you like to register another passenger? yes = y  no = n\n");
                            Console.WriteLine();
                            answer = Console.ReadLine().ToLower();

                            
                            } while (answer == "y");

                            Console.Clear();
                            break;
                           
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Show Registered Tickets");
                        Console.WriteLine();

                        for (int i = 0; i < counter; i++)
                        {
Console.WriteLine();
Console.WriteLine($"Passenger: {names[i]} | Origin: {origin[i]} | Destiny: {destiny[i]} | Data of Travel: {data[i]}");
                            
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Thank you for choosing Marini AirLines");
                        break;
                    
                    default:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Option");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                }
            
            
            } while (choice != 3);

            
            
            
        }
    }
}
