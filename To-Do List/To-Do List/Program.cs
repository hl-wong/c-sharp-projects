// See https://aka.ms/new-console-template for more information

using System.Collections;

namespace To_Do_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            bool exit = false;

            while (!exit)
            {
                Run();

                try
                {
                    Console.Write("\nPlease enter the choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    Task task;

                    switch (choice)
                    {
                        case 1:
                            // Add Task
                            Console.Write("\nPlease enter the task name: ");
                            string task_name = Console.ReadLine().Trim();

                            if (task_name != "")
                            {
                                task = new Task(task_name, false, tasks);
                                task.AddTask(task);
                            }
                            else
                            {
                                Console.WriteLine("Task name cannot be empty.\n");
                            }
                            break;
                        case 2:
                            // Update Task
                            task = new Task(tasks);
                            task.UpdateTask();
                            break;
                        case 3:
                            // Delete Task
                            task = new Task(tasks);
                            task.DeleteTask();
                            break;
                        case 4:
                            // View Tasks
                            task = new Task(tasks);
                            task.ViewTasks();
                            break;
                        case 5:
                            exit = true;
                            Console.WriteLine("Exit program.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice.\n");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a number.\n");
                }
            }

            static void Run()
            {
                Console.WriteLine("To-Do List");
                Console.WriteLine("==========");
                Console.WriteLine("[1] Add Task");
                Console.WriteLine("[2] Update Task");
                Console.WriteLine("[3] Delete Task");
                Console.WriteLine("[4] View Tasks");
                Console.WriteLine("[5] Exit");
            }
        }
    }
}
