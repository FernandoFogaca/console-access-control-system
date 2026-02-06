namespace TrainingDay09;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("******************** Console Access Control System ********************");
        Console.WriteLine();

        bool valid = true;
        int option = 0;

        while (valid)
        {
            Console.WriteLine(" ------------ Choose one of the options below ------------ ");
            Console.WriteLine();
            Console.WriteLine(
                " 1 - Access the System\n" +
                " 2 - Name List\n" +
                " 3 - Event Information\n" +
                " 4 - Contacts\n" +
                " 0 - Exit the System.\n "
            );

            string input = Console.ReadLine()!;
            Console.Clear();

            if (!int.TryParse(input, out option))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error, try again. Only numbers are accepted.");
                Console.ResetColor();
                continue;
            }

            switch (option)
            {
                case 1:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(
                        "Accessing the system...\n" +
                        "Welcome to our system..."
                    );
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("\nPress ENTER to return to the menu...");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine(
                        "---------- Name List ----------\n\n" +
                        "Here you can access the list of all clients " +
                        "and guests to validate their information."
                    );
                    Console.WriteLine();
                    Console.WriteLine("\nPress ENTER to return to the menu...");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 3:
                    Console.WriteLine();
                    Console.WriteLine(
                        " ------ Event Information ------\n" +
                        "Welcome to the Event Information menu.\n" +
                        "Here you can find details about each area of the event, " +
                        "including locations and dates."
                    );
                    Console.WriteLine();
                    Console.WriteLine("\nPress ENTER to return to the menu...");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine(
                        "------ Contacts ------\n\n" +
                        "Welcome to the contacts menu.\n" +
                        "Here you can find all ways to contact the event production team.\n" +
                        "Phones: +031 66688878, +031 66689787\n" +
                        "Email: dsfsdfsf@gewwfwefwe\n" +
                        "Ticket purchase link: www.eventstoday.uk\n" +
                        "Event location: Oxford Street 1000, London, UK\n" +
                        "Event location: Ziggo Dome 12, Amsterdam, NL\n"
                    );
                    Console.WriteLine();
                    Console.WriteLine("\nPress ENTER to return to the menu...");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 0:
                    Console.WriteLine();
                    Console.WriteLine(
                        "You have exited the system.\n" +
                        "We hope to see you again soon."
                    );
                    Console.WriteLine("Thank you very much for using our service.");
                    Console.WriteLine();
                    valid = false;
                    break;

                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Invalid option. Returning to the main menu.");
                    Console.ResetColor();
                    Console.WriteLine("\nPress ENTER to return to the menu...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
}
