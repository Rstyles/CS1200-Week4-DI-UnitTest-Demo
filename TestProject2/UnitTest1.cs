using UnitTestDemo.Interfaces;
using UnitTestDemo.Models;
using UnitTestDemo.Services;

namespace TestProject2;

public class UnitTest1
{
    // mock up the note service
    INoteService noteService = new NoteService();

    [Fact]
    public void Addnote_shouldaddnotetonotes()
    {
        // Arrange
        var note = new Note("Test note");

        // Act
        noteService.AddNote(note);

        // Assert
        Assert.Contains(note, noteService.Notes);
    }
}