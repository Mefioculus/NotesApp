using Xunit;
using NotesLibs;

namespace NotesTests
{
    public class TestingElementOfSentence {
        [Fact]
        public void TestOfLink() {
            // Проверка создания объектов предложения

            string textOfLink = "[Описание ссылки](https.google.com)";

            LinkElement link = new LinkElement(textOfLink);

            Assert.Equal(TypeOfElementSentence.LinkText, link.Type);
            Assert.Equal(textOfLink, link.Text);
            Assert.Equal("Описание ссылки", link.Alias);
            Assert.Equal("https.google.com", link.Address);
        }

        [Fact]
        public void TestOfSimpleText() {
            string text = "Простой текст";
            SimpleTextElement simpleText = new SimpleTextElement(text);

            Assert.Equal(TypeOfElementSentence.SimpleText, simpleText.Type);
            Assert.Equal(text, simpleText.Text);
        }

        [Fact]
        public void TestOfBoldText() {
            string text = "Жирный текст";
            BoldTextElement boldText = new BoldTextElement(text);

            Assert.Equal(TypeOfElementSentence.BoldText, boldText.Type);
            Assert.Equal(text, boldText.Text);
        }

        [Fact]
        public void TestOfItalicText() {
            string text = "Курсивный текст";
            ItalicTextElement italicText  = new ItalicTextElement(text);

            Assert.Equal(TypeOfElementSentence.ItalicText, italicText.Type);
            Assert.Equal(text, italicText.Text);
        }

        [Fact]
        public void TestOfBoldItalicText() {
            string text = "Жирный курсивный текст";
            BoldItalicTextElement boldItalicText = new BoldItalicTextElement(text);

            Assert.Equal(TypeOfElementSentence.BoldItalicText, boldItalicText.Type);
            Assert.Equal(text, boldItalicText.Text);
        }

        [Fact]
        public void TestOfCodeText() {
            string text = "Элемент кода в тексте";
            string language = "csharp";
            CodeElement firstCodeElement = new CodeElement(text);
            CodeElement secondCodeElement = new CodeElement(text, language);

            Assert.Equal(TypeOfElementSentence.CodeText, firstCodeElement.Type);
            Assert.Equal(text, firstCodeElement.Text);
            Assert.Equal(string.Empty, firstCodeElement.Language);
            Assert.Equal(TypeOfElementSentence.CodeText, secondCodeElement.Type);
            Assert.Equal(text, secondCodeElement.Text);
            Assert.Equal(language, secondCodeElement.Language);
        }
    }
}
