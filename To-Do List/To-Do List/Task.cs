using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    class Task
    {
        private string name;
        private bool status;
        private List<Task> tasks;

        public Task(string name, bool status, List<Task> tasks)
        {
            this.name = name;
            this.status = status;
            this.tasks = tasks;
        }

        public Task(List<Task> tasks)
        {
            this.tasks = tasks;
        }

        public string Name
        {
            get { return name; } set { name = value; }
        }

        public bool Status
        {
            get { return status; } set { status = value; }
        }

        public List<Task> Tasks
        {
            get { return tasks; } set { tasks = value; }
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
            Console.WriteLine("Task have been added to the List.\n");
        }

        public void UpdateTask()
        {
            if (!CheckTaskSize())
            {
                Console.WriteLine("There are no task yet.\n");
            }
            else
            {
                DisplayTasks();

                try
                {
                    Console.Write("Please enter the choice to update task: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice > 0 && choice <= tasks.Count)
                    {
                        Console.Write("\nPlease enter the task name (optional): ");
                        string task_name = Console.ReadLine().Trim();

                        // if task_name is empty, automatically assign the existing value to task_name instead of empty.
                        if (task_name == "")
                        {
                            task_name = tasks[choice - 1].Name;
                        }

                        Console.WriteLine("\nTask Status");
                        Console.WriteLine("===========");
                        Console.WriteLine("[1] Incomplete");
                        Console.WriteLine("[2] Complete");

                        try
                        {
                            Console.Write("Please update the task status: ");
                            int task_status = Convert.ToInt32(Console.ReadLine());

                            Task task;

                            switch (task_status)
                            {
                                case 1:
                                    task = new Task(task_name, false, tasks);
                                    tasks[choice - 1] = task;
                                    break;
                                case 2:
                                    task = new Task(task_name, true, tasks);
                                    tasks[choice - 1] = task;
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice.");
                                    break;
                            }
                            Console.WriteLine("Task have been updated to the List.\n");
                        }
                        catch
                        {
                            Console.WriteLine("Please enter a number.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.\n");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a number.\n");
                }
            }
        }

        public void DeleteTask()
        {
            if (!CheckTaskSize())
            {
                Console.WriteLine("There are no task yet.\n");
            }
            else
            {
                DisplayTasks();
                
                try
                {
                    Console.Write("Please enter the choice to delete task: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice > 0 && choice <= tasks.Count)
                    {
                        tasks.Remove(tasks[choice - 1]);
                        Console.WriteLine("Task have been deleted from the List.\n");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.\n");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a number.\n");
                }
            }
        }

        public void ViewTasks()
        {
            if (!CheckTaskSize())
            {
                Console.WriteLine("There are no task yet.\n");
            }
            else
            {
                DisplayTasks();
            }
        }

        public bool CheckTaskSize()
        {
            if (tasks.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void DisplayTasks()
        {
            Console.WriteLine("\nTasks");
            Console.WriteLine("=====");
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].Status == true)
                {
                    Console.WriteLine("[" + (i + 1) + "] " + tasks[i].Name + " / Complete");
                }
                else
                {
                    Console.WriteLine("[" + (i + 1) + "] " + tasks[i].Name + " / Incomplete");
                }

                if (i == tasks.Count - 1) { Console.WriteLine("\n"); }
            }
        }
    }
}
