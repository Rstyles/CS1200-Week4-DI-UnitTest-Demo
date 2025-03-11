using UnitTestDemo.Interfaces;
using UnitTestDemo.Models;

namespace UnitTestDemo.Services;

public class NoteService : INoteService
{
    public Note[] Notes { get; set; } = [];

    public NoteService()
    {
        Notes = [new Note("Buy milk"), new Note("Call mom"), new Note("Do homework", true), new Note("Go to the gym"), new Note("Buy eggs")];
    }

    public void AddNote(Note note)
    {
        if (note == null)
        {
            throw new ArgumentNullException(nameof(note));
        }
        Note[] notes = new Note[Notes.Length + 1];
        Array.Copy(Notes, notes, Notes.Length);
        notes[Notes.Length] = note;
        Notes = notes;
    }

    public void RemoveNote(Note note)
    {
        if (note == null)
        {
            throw new ArgumentNullException(nameof(note));
        }
        Note[] notes = new Note[Notes.Length - 1];
        int index = 0;
        foreach (Note n in Notes)
        {
            if (n.Title != note.Title)
            {
                notes[index++] = n;
            }
        }
        Notes = notes;
    }

    public void ToggleCompleted(Note note)
    {
        if (note == null)
        {
            throw new ArgumentNullException(nameof(note));
        }
        foreach (Note n in Notes)
        {
            if (n.Title == note.Title)
            {
                n.IsCompleted = !n.IsCompleted;
            }
        }
    }

    public void DisplayNotes()
    {
        foreach (Note note in Notes)
        {
            if (note.IsCompleted)
            {
                Console.WriteLine($"[x] {Array.IndexOf(Notes, note)} Title: {note.Title}");
            }
            else
            {
                Console.WriteLine($"[ ] {Array.IndexOf(Notes, note)} Title: {note.Title}");
            }
        }
    }
}
