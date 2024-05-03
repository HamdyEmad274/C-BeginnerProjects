namespace To_Do_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Your To Do List");
            List<string> taskList = new List<string>();
            string option = "";
            while (option != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. View Tasks");
                Console.WriteLine("c. Clear Screen");
                Console.WriteLine("e. Exit");
                option = Console.ReadLine();
               if (option == "1")
                {
                    Console.WriteLine("What task would you like to add?");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("*************************");
                    Console.WriteLine("Task Added Successfully!");
                    Console.WriteLine("*************************");
                }
                else if (option == "2")
                {
                    Console.WriteLine("What task would you like to remove?");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {taskList[i]}");

                    }
                    int index = int.Parse(Console.ReadLine());
                    taskList.RemoveAt(index - 1);
                    Console.WriteLine("*************************");
                    Console.WriteLine("Task Removed Successfully!");
                    Console.WriteLine("*************************");
                }
                else if (option == "3")
                {
                    Console.WriteLine("Here are your tasks:");
                    Console.WriteLine("----------------------");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {taskList[i]}");
                    }
                    Console.WriteLine("----------------------");
                }
                else if (option.ToLower() == "c")
                {
                    Console.Clear();
                }
                else if (option.ToLower() == "e")
                {
                    Console.WriteLine("*************************");
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine("*************************");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }
            Console.WriteLine("Thank you for using the To Do List!");
        }
    }
    }
