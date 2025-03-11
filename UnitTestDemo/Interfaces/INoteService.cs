using System;
using UnitTestDemo.Models;

namespace UnitTestDemo.Interfaces;

public interface INoteService
{
    Note[] Notes { get; set; }

    void AddNote(Note note);
    void DisplayNotes();
    void ToggleCompleted(Note note);
    void RemoveNote(Note note);
}