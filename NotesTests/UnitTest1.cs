using Xunit;
using NotesLibs;

namespace NotesTests
{
    public class TestingElementOfSentence {
        [Fact]
        public void TestOfLink() {
            // Проверка создания объектов предложения

            string textOfLink = "[Описание ссылки](https.google.com)";

            Link link = new Link(textOfLink);

            Assert.Equal(TypeOfElementSentence.Link, link.Type);
            Assert.Equal(textOfLink, link.Text);
            Assert.Equal("Описание ссылки", link.Alias);
            Assert.Equal("https.google.com", link.Address);
        }

        [Fact]
        public void TestOfSimpleText() {
            string text = "Простой текст";
            SimpleText simpleText = new SimpleText(text);

            Assert.Equal(TypeOfElementSentence.SimpleText, simpleText.Type);
            Assert.Equal(text, simpleText.Text);
        }
    }
}
