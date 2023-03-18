public class Reference

{
    public Reference(string book, int Chapter, int Verse)
    {
        _book = book;
        _chapter = Chapter;
        _verse = Verse;

    }

    public Reference(string v)
    {
        this.v = v;
    }

    private string book;
    private string GetBook()
    {
        return book;
    }
    private string SetBook(string book)
    {
        _book = book;
    
    }
    private int chapter;
    private string GetChapter()
    {
        return chapter;
    }
    private int verse;


    private string GetVerse()
    {
        return verse;
    }
    public string Display()
    {
        if (verse == 0)
        {
            return($"{_book}{_chapter}:{verse}");
        }
        else {
            return($"{_book}{_chapter}{verse}");
        }
    }
}