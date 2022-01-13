namespace NotesLibs {

    // Класс для хранения одной отдельной записи
    public interface INote {
        public int ID { get; }

        public void Add(string text);
        public void Save();
    }

    public interface IElementOfSentenceClass {
        // Properties
        public TypeOfElementSentence Type { get; }
        public string Text { get; }

        // Methods
        public string ToString(IRenderer renderer);
    }

    public interface IRenderer {
    }
}
