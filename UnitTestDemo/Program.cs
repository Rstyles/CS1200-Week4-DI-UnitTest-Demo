using UnitTestDemo.Interfaces;
using UnitTestDemo.Services;

namespace UnitTestDemo;

class Program
{
    static void Main(string[] args)
    {
        INoteService noteService = new NoteService();
        ConsoleIO consoleIO = new ConsoleIO(noteService);

        consoleIO.Run();
    }
}
