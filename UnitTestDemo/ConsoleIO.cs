using System;
using UnitTestDemo.Interfaces;

namespace UnitTestDemo;

public class ConsoleIO
{
    public INoteService NoteService { get; set; }
    public ConsoleIO(INoteService noteService)
    {
        NoteService = noteService;
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Notes App");
        Console.WriteLine("1. View Notes");
        Console.WriteLine("2. Add Note");
        Console.WriteLine("3. Delete Note");
        Console.WriteLine("4. Toggle Completed");
        Console.WriteLine("5. Exit");
        Console.Write("Select an option: ");
    }

    public void AddNote()
    {
        Console.Write("Enter note title: ");
        string title = Console.ReadLine();
        NoteService.AddNote(new Models.Note(title));
    }

    public void DeleteNote()
    {
        Console.Write("Enter note title: ");
        string title = Console.ReadLine();
        NoteService.RemoveNote(new Models.Note(title));
    }

    public void ViewNotes()
    {
        NoteService.DisplayNotes();
    }

    public void ToggleCompleted()
    {
        Console.Write("Enter note title: ");
        string title = Console.ReadLine();
        NoteService.ToggleCompleted(new Models.Note(title));
    }

    public void Run()
    {
        while (true)
        {
            DisplayMenu();
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    ViewNotes();
                    break;
                case "2":
                    AddNote();
                    break;
                case "3":
                    DeleteNote();
                    break;
                case "4":
                    ToggleCompleted();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }

}
