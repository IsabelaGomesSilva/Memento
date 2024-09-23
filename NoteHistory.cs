namespace NotionMementoPattern
{
   public class NoteHistory
    {
        private List<INoteMemento> _history = new List<INoteMemento>();
        private UserNote _note;

        public NoteHistory(UserNote note)
        {
            this._note = note;
        }

        public void Save()
        {
            Console.WriteLine("NoteHistory: Saving current note state...");
            _history.Add(_note.Save());
        }

        public void Undo()
        {
            if (_history.Count == 0)
            {
                Console.WriteLine("NoteHistory: No previous states to restore.");
                return;
            }

            var memento = _history[_history.Count - 1];
            _history.RemoveAt(_history.Count - 1);

            Console.WriteLine("NoteHistory: Restoring to previous state...");
            _note.Restore(memento);
        }
        public void ShowHistory()
        {
            Console.WriteLine("NoteHistory: Displaying saved states:");
            foreach (var memento in _history)
            {
                Console.WriteLine($"Saved at: {memento.GetDate()} | Content Snapshot: {memento.GetContent().Substring(0, Math.Min(10, memento.GetContent().Length))}...");
            }
        }
    }
}