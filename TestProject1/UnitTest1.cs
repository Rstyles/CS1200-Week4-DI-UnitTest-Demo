using UnitTestDemo.Interfaces;
using UnitTestDemo.Models;
using UnitTestDemo.Services;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var noteService = new NoteService();
        SeedData(noteService);

        Assert.Equal(5, noteService.Notes.Length);
    }

    static void SeedData(INoteService noteService)
    {
        noteService.AddNote(new Note("Buy milk"));
        noteService.AddNote(new Note("Call mom"));
        noteService.AddNote(new Note("Do homework", true));
        noteService.AddNote(new Note("Go to the gym"));
        noteService.AddNote(new Note("Buy eggs"));
    }
}