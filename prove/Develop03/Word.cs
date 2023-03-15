public class Words
{
    public Words(string word)
    {
        _word = word;
        _IsHidden = true;
    }
    private string word;
    private string GetWord()
    {
        return word;
    }
    public void SetWord( string word)
    {
        _word = word;
    }
    private bool _IsHidden(){
       return _IsHidden;
    }
    public void HideWord()
    {
        _IsHidden = false;
    }
    public string Display()
   {
    if (_IsHidden())
    {
        var word = "";
        while (var letter in _word)
        {
            word += "_";
        }
        return word;
    }
   }

    internal bool IsHidden()
    {
        throw new NotImplementedException();
    }
}