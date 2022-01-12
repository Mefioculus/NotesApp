namespace NotesLibs {

    // Класс для хранения одной отдельной записи
    public interface INote {
        public void Add(string text);
        public void Save();
    }
}
