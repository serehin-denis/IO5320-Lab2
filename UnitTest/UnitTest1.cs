using laba2;
namespace UnitTest;

public class UnitTest1

{
    [Fact]
    public void GetSimilarCountTest()
    {
        string testPoem = "Тестове речення для перевірки.";
        string expectedResult = "Тстове речення для перевірки.";
        
        StrOperations poem = new StrOperations(testPoem);
        
        Assert.Equal(expectedResult, poem.FilterLetters());
    }
}