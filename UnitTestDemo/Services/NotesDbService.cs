using System;
using UnitTestDemo.Interfaces;
using UnitTestDemo.Models;

namespace UnitTestDemo.Services;

public class NotesDbService : INoteService
{
    public Note[] Notes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void AddNote(Note note)
    {
        throw new NotImplementedException();
    }

    public void DisplayNotes()
    {
        throw new NotImplementedException();
    }

    public void RemoveNote(Note note)
    {
        throw new NotImplementedException();
    }

    public void ToggleCompleted(Note note)
    {
        throw new NotImplementedException();
    }
}
