using NotionMementoPattern;

UserNote note = new UserNote("Initial note content.");
NoteHistory history = new NoteHistory(note);

history.Save();
note.Edit("First edit to the note.");

history.Save();
note.Edit("Second edit to the note.");

history.Save();
note.Edit("Third edit to the note.");

Console.WriteLine();
history.ShowHistory();

Console.WriteLine("\nUndo last change:");
history.Undo();

Console.WriteLine("\nUndo another change:");
history.Undo();

Console.WriteLine();
history.ShowHistory();