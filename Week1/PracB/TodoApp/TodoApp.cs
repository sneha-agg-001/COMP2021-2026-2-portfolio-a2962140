using System;
using System.Collections.Generic;

public class TodoApp
{
    private List<string> tasks = new List<string>();
    private Dictionary<string, List<int>> tags = new Dictionary<string, List<int>>();

    public void Run()
    {
        while (true)
        {
            Console.Write("> ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please enter a command.");
                continue;
            }

            string[] parts = input.Split(' ', 2);
            string command = parts[0].ToLower();

            switch (command)
            {
                case "add":
                    AddTask(parts);
                    break;

                case "show":
                    ShowTasks();
                    break;

                case "remove":
                    RemoveTask(parts);
                    break;

                case "clear":
                    ClearTasks();
                    break;

                case "tag":
                    TagTask(parts);
                    break;

                case "get-tagged":
                    GetTagged(parts);
                    break;

                case "exit":
                    return;

                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }
        }
    }


    private void AddTask(string[] parts)
    {
        if (parts.Length < 2 || string.IsNullOrWhiteSpace(parts[1]))
        {
            Console.WriteLine("Usage: add [item]");
            return;
        }

        tasks.Add(parts[1]);
        Console.WriteLine("Task added.");
    }


    private void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks.");
            return;
        }

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i}: {tasks[i]}");
        }
    }


    private void RemoveTask(string[] parts)
    {
        if (parts.Length < 2 || !int.TryParse(parts[1], out int index))
        {
            Console.WriteLine("Usage: remove [index]");
            return;
        }

        if (index < 0 || index >= tasks.Count)
        {
            Console.WriteLine("Invalid index.");
            return;
        }

        tasks.RemoveAt(index);
        Console.WriteLine("Task removed.");
    }


    private void ClearTasks()
    {
        tasks.Clear();
        Console.WriteLine("All tasks cleared.");
    }


    private void TagTask(string[] parts)
    {
        string[] arguments = parts.Length > 1 
            ? parts[1].Split(' ') 
            : Array.Empty<string>();

        if (arguments.Length < 2)
        {
            Console.WriteLine("Usage: tag [index] [name]");
            return;
        }

        if (!int.TryParse(arguments[0], out int index))
        {
            Console.WriteLine("Index must be a number.");
            return;
        }

        if (index < 0 || index >= tasks.Count)
        {
            Console.WriteLine("Invalid task index.");
            return;
        }

        string tagName = arguments[1].ToLower();

        if (!tags.ContainsKey(tagName))
        {
            tags[tagName] = new List<int>();
        }

        if (tags[tagName].Contains(index))
        {
            Console.WriteLine("Tag already exists for this task.");
            return;
        }

        tags[tagName].Add(index);

        Console.WriteLine("Tag added.");
    }


    private void GetTagged(string[] parts)
    {
        if (parts.Length < 2)
        {
            Console.WriteLine("Usage: get-tagged [tag]");
            return;
        }

        string tagName = parts[1].ToLower();

        try
        {
            List<int> indexes = tags[tagName];

            foreach (int index in indexes)
            {
                Console.WriteLine($"{index}: {tasks[index]}");
            }
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Tag not found.");
        }
    }
}