namespace NotesLibs {

    public abstract class ElementOfSentenceClass : IElementOfSentenceClass {
        public TypeOfElementSentence Type { get; private set; }
        public string Text { get; private set; }

        public ElementOfSentenceClass(TypeOfElementSentence type, string text) {
            this.Type = type;
            this.Text = text;
        }

        public override string ToString() {
            return this.Text;
        }

        public string ToString(IRenderer renderer) {
            return this.Text;
        }
    }


    public enum TypeOfElementSentence {
        SimpleText,
        Link,
        BoldText,
        ItalicText,
        BoldItalicText,
        Code
    }

    public class Link : ElementOfSentenceClass {
        public string Alias { get; private set; }
        public string Address { get; private set; }

        public Link(string content) : base(TypeOfElementSentence.Link, content) {
            int startIndexOfAlias = this.Text.IndexOf('[') + 1;
            int endIndexOfAlias = this.Text.IndexOf(']');
            int startIndexOfAdress = this.Text.IndexOf('(') + 1;
            int endIndexOfAdress = this.Text.IndexOf(')');
            this.Alias = this.Text.Substring(startIndexOfAlias, endIndexOfAlias - startIndexOfAlias);
            this.Address = this.Text.Substring(startIndexOfAdress, endIndexOfAdress - startIndexOfAdress);
        }
    }

    public class SimpleText : ElementOfSentenceClass {
        public SimpleText(string content) : base(TypeOfElementSentence.SimpleText, content) {
        }
    }

}
