namespace NotionMementoPattern
{
    public class NoteMemento : INoteMemento
    {
        private string _content;
        private DateTime _date;

        public NoteMemento(string content)
        {
            this._content = content;
            this._date = DateTime.Now;
        }

        public string GetContent()
        {
            return this._content;
        }

        public DateTime GetDate()
        {
            return this._date;
        }
    }
}