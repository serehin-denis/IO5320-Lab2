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

    public int GetSimilarCount()
    {
        string[] splittedText = _text.Split(new char[] { '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
        int counter = 0;

        for (int i = 0; i < splittedText.Length; i++)
        {
            string[] words = splittedText[i].Split(new char[] { ' ', ',', '\n', '-'}, StringSplitOptions.RemoveEmptyEntries);
            
            HashSet<string> uniqueWords = new HashSet<string>();

            foreach (string word in words)
            {
                if (!uniqueWords.Add(word.ToLower()))
                {
                    counter++;
                    break;
                }
            }
            
        }
            
        
        return counter;
    }
}