public class Scripture
{
 public Scripture( Reference reference, string scripture)
 {
    _reference = reference;
    _words= NewWordsList(scripture);
 }
 private Reference _reference;
 private Reference GetReference()
 {
    return _reference;
 }
 public void SetReference(Reference reference)
 {
    _reference = reference;
 }
 private List<Words> _words;
 private List<Words> GetList()
 {
    return Words;
 }
 private void SetList(string scripture)
 {
    _words = NewWordsList(scripture);
 }
 private List<Words> NewWordsList(string scripture)
 {
    foreach(Words in scripture.Split(" "))
    {
       Scripture.NewWordsList.Add(new Words(word));
    }
    return NewWordsList;
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