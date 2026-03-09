namespace laba2;

public class StrOperations
{
    private string _text = null!;

    private string Data
    {
        get => _text;
        set
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value), "Текст не може бути Null"); 
            if (value.Length == 0)
                throw new Exception("Текст не може бути порожнім\n");
            _text = value;
        }
    }
    
    
    public StrOperations(string text)
    {
        Data = text;
    }
    
    public override string ToString()
    {
        return Data;
    }

    private string LettersRemove(string word)
    {
        char badChar = word[word.Length - 1];
        string result = "";

        for (int i = 0; i < word.Length; i++)
        {
            if (char.ToLower(badChar) != char.ToLower(word[i]))  result += word[i];
        }
        result += badChar;
        
        return result;
    }
    
    public string FilterLetters()
    {
        string currentWord = "";
        string result = "";

        for (int i = 0; i < Data.Length; i++)
        {
            char c = Data[i];
            if (char.IsLetter(c))
            {
                currentWord += c;
            }
            else
            {
                if (currentWord.Length > 0)
                {
                    result += LettersRemove(currentWord);
                    currentWord = "";
                }
                result += c;
            }

            
            
        }
        if (currentWord.Length > 0) result += LettersRemove(currentWord);
        
        return result;
    }
}