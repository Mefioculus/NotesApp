using System.Collections.Generic;

namespace NotesLibs {

    public class SentenceClass {

        private List<IElementOfSentenceClass> ContentOfSentence { get; set; }
        private TypeOfSentence Type { get; set; }

        public SentenceClass(string sentence) {
            // Обработка текста предложения
            if (string.IsNullOrWhiteSpace(sentence)) {
                this.Type = TypeOfSentence.Empty;
                return;
            }
        }

    }

    public enum TypeOfSentence {
        UnorderedListItem,
        OrderedListItem,
        SimpleSentence,
        Quote,
        Header,
        Link,
        Code,
        Empty
    }

}
