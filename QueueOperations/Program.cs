using QueueOperations;

namespace QueueOperations
{
    public class Program
    {
        static QueueManager qm = new QueueManager();

        public static void Main(string[] args)
        {
            bool displayMainMenu = true;

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
                ConsoleHelper.Header("H1 Queue Operations Menu");

                ChooseAction(ConsoleHelper.MultipleChoice(false, 1, 7, mainMenuOptions));
            } while (displayMainMenu = true);
        }
        public void ChooseAction(int actionId)
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
                    ShowItems();
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

            qm.AddItems(name);
        }

        public static void DeleteItems()
        {
            Console.WriteLine(qm.DeleteItems());
        }

        public static void ShowItems()
        {
            Console.WriteLine(qm.ShowItems());
        }
    }
}