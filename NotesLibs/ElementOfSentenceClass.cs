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
        LinkText,
        BoldText,
        ItalicText,
        BoldItalicText,
        CodeText
    }

    public class LinkElement : ElementOfSentenceClass {
        public string Alias { get; private set; }
        public string Address { get; private set; }

        public LinkElement(string content) : base(TypeOfElementSentence.LinkText, content) {
            int startIndexOfAlias = this.Text.IndexOf('[') + 1;
            int endIndexOfAlias = this.Text.IndexOf(']');
            int startIndexOfAdress = this.Text.IndexOf('(') + 1;
            int endIndexOfAdress = this.Text.IndexOf(')');
            this.Alias = this.Text.Substring(startIndexOfAlias, endIndexOfAlias - startIndexOfAlias);
            this.Address = this.Text.Substring(startIndexOfAdress, endIndexOfAdress - startIndexOfAdress);
        }
    }

    public class SimpleTextElement : ElementOfSentenceClass {
        public SimpleTextElement(string content) : base(TypeOfElementSentence.SimpleText, content) {
        }
    }

    public class BoldTextElement : ElementOfSentenceClass {
        public BoldTextElement(string content) : base(TypeOfElementSentence.BoldText, content) {
        }
    }

    public class ItalicTextElement : ElementOfSentenceClass {
        public ItalicTextElement(string content) : base(TypeOfElementSentence.ItalicText, content) {
        }
    }

    public class BoldItalicTextElement : ElementOfSentenceClass {
        public BoldItalicTextElement(string content) : base(TypeOfElementSentence.BoldItalicText, content) {
        }
    }

    public class CodeElement : ElementOfSentenceClass {
        public string Language { get; private set; }
        public CodeElement(string content, string language = "") : base(TypeOfElementSentence.CodeText, content) {
            Language = language;
        }
    }

}
