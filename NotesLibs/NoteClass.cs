using System.Collections.Generic;

namespace NotesLibs {

    // Класс для хранения одной отдельной записи
    public class NoteClass :  INote {

        #region Fields and Properties

        public List<string> sentences { get; private set; }

        #endregion Fields and Properties


        public void Add(string text) {
        }

        private List<string> ProcessText(string text) {
            return new List<string>();
        }

        private SentenceClass ProcessSentence(string sentence) {
            return new SentenceClass();
        }

        public void Save() {
        }
        
    }
}
