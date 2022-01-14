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

            // Обрабатываем текст для получения объектов ElementOfSentenceClass
            this.ContentOfSentence = ParseSentence(sentence);
        }

        private List<IElementOfSentenceClass> ParseSentence(string sentence) {
            List<IElementOfSentenceClass> elementsOfSentence = new List<IElementOfSentenceClass>();

            // TODO Реализовать код, который будет разбирать предложение на части и получать из него
            // элементы предложения

            return elementsOfSentence;
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
