ublic class Entry {

    public string _place = "";
    
    public string _date = "";
    public string _prompt = "";
    public string _response = "";

    public void journalEntry ()
    {
        Console.WriteLine($"Date: {_date} - Place: {_place} Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");

    }
}