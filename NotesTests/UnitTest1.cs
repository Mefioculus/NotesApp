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

            Assert.Equal(TypeOfElementSentence.Link, link.Type);
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
    }
}
