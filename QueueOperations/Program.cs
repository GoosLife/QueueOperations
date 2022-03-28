using System;
using QueueOperations;

namespace QueueOperations
{
    public class Program
    {
        static QueueManager qm = new QueueManager();
        static bool displayMainMenu = true;

        public static void Main(string[] args)
        {
            string[] mainMenuOptions = new string[] {"1. Add items",
            "2. Delete items",
            "3. Show the number of items",
            "4. Show first and last item",
            "5. Find item",
            "6. Print all items",
            "7. Exit"};

            ConsoleHelper.SetupConsole();

            do
            {
                Console.Clear();

                ConsoleHelper.Header("H1 Queue Operations Menu");

                ChooseAction(ConsoleHelper.MultipleChoice(false, 1, 7, mainMenuOptions));
            } while (displayMainMenu == true);
        }
        public static void ChooseAction(int actionId)
        {
            switch (actionId)
            {
                case 0:
                    AddItems();
                    break;
                case 1:
                    DeleteItems();
                    break;
                case 2:
                    ShowNumberOfItems();
                    break;
                case 3:
                    ShowFirstAndLast();
                    break;
                case 4:
                    FindItem();
                    break;
                case 5:
                    PrintAllItems();
                    break;
                case 6:
                    Exit();
                    break;
            }
        }

        public static void AddItems()
        {
            Console.Clear();

            Console.WriteLine("Input name of card to add: ");
            string name = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(name))
            {
                qm.AddItems(name);
                Console.WriteLine($"Added {name} to the list of cards.");
            }
            else
            {
                Console.WriteLine("Please enter a name for the card to add and try again.");
            }
            
            Console.ReadKey();
        }

        public static void DeleteItems()
        {
            Console.Clear();
            Console.WriteLine(qm.DeleteItems());
            Console.ReadKey();
        }

        public static void ShowNumberOfItems()
        {
            Console.Clear();
            Console.WriteLine(qm.ShowNumberOfItems());
            Console.ReadKey();
        }

        public static void ShowFirstAndLast()
        {
            Console.Clear();
            Console.WriteLine(qm.ShowFirstAndLast());
            Console.ReadKey();
        }
        
        public static void FindItem()
        {
            Console.Clear();

            Console.WriteLine("Input search query: ");
            string searchQuery = Console.ReadLine();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                Console.WriteLine(qm.FindItem(searchQuery));
            }
            else
            {

            }

            Console.ReadKey();
        }

        public static void PrintAllItems()
        {
            Console.Clear();
            Console.WriteLine(qm.PrintAllItems());
            Console.ReadKey();
        }

        public static void Exit()
        {
            Console.Clear();

            displayMainMenu = false;

            Console.WriteLine("Bye, bye!");
            Console.ReadKey();
        }
    }
}