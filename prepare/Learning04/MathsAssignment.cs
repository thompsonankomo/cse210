public class MathsAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
        {
            _textBookSection  = textbookSection Section;
            _problems = problems;

        }
        public string GetHomeworkList()
        {
            
        return $"Section {_textbookSection} Problems {_problems}";
        }
}