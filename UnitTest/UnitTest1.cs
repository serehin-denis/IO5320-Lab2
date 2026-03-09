using laba2;
namespace UnitTest;

public class UnitTest1

{
    [Fact]
    public void GetSimilarCountTest()
    {
        string testPoem = "Ображайся на мене, як хочеш,\n" +
                          "Зневажай, ненавидь мене –\n" +
                          "Все одно я люблю твої очі\n" +
                          "І волосся твоє сумне.\n\n" +
                          "Хай досада чи гнів жевріє,\n" +
                          "Хай до сліз я тебе озлю –\n" +
                          "Ти для мене не тільки мрія,\n" +
                          "Я живою себе люблю.";
        int num = 2;
        
        StrOperations poem = new StrOperations(testPoem);
        
        Assert.Equal(num, poem.GetSimilarCount());
    }
}