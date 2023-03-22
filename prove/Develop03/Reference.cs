public class Reference

{
    public Reference(string book, int Chapter, int Verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }
    public Reference(string book, int chapter,int verse, int EndVerse)
    {
     _book =book;
     _chapter = chapter;
     _verse = verse;
     

    }
    private string book;
    private string GetBook()
    {
        return _book;
    }
    private string SetBook(string book)
    {
        _book = book;
    
    }
    private int chapter;
    private string GetChapter()
    {
        return _chapter;
    }
    private int verse;


    private string GetVerse()
    {
        return _verse;
    }
    private int verse;
    private int GetVerse()
    {
     return _verse;
    }
    private int EndVerse;
    private int GetEndVerse()
    {return _EndVerse;}

    public string Display()
    {
        if (_EndVerse< 0)
        {
            return($"{_book}{_chapter} -{_EndVerse}");
        }
        else {
            return($"{_book}{_chapter}{_EndVerse}");
        }
    }
}