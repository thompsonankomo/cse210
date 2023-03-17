public class Scripture
{
 public Scripture( Reference reference, string scripture)
 {
    _reference = reference;
    _words= WordsList(scripture);
 }
 private Reference _reference;
 private Reference GetReference()
 {
    return _reference;
 }
 public void SetReference(Reference _reference)
 {
    _reference = reference;
 }
 private List<Words> _words;
 private List<Words> GetList()
 {
    return _words;
 }
 private void SetList(string scripture)
 {
    _words = WordsList(scripture);
 }
 private List<Words> WordsList(string scripture)
 {
    foreach(Words in scripture.Split(" "))
    {
       Scripture.WordsList.Add(new Words(word));
    }
    return WordsList;
 }
 public string Display()
 {
    string scripture =" ";
    scripture += _reference.Display() + " ";
    foreach (var word in _words)
    {
        if(!word.IsHidden())
        {
            return true;
        }
   
        
    }

 }
}