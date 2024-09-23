namespace NotionMementoPattern
{
    public class UserNote
    {
        private string _content;

        public UserNote(string content)
        {
            this._content = content;
            Console.WriteLine("UserNote: Initial content is: " + content +"\n");
        }

        public void Edit(string newContent)
        {
            Console.WriteLine("UserNote: Editing note...\n");
            this._content = newContent;
            Console.WriteLine($"UserNote: New content is: {_content} \n");
        }

        public INoteMemento Save()
        {
            return new NoteMemento(_content);
        }

        public void Restore(INoteMemento memento)
        {
            if (!(memento is NoteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            this._content = memento.GetContent();
            Console.WriteLine($"UserNote: Content restored to: {_content}");
        }
    }
}