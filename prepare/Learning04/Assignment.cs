public class Assignment
{
    private string _studentName;
    private string _topic;

    public class Asssignment(  string studentName, string topic)
    {
     _studentName = studentName;
     _topic = topic;
    }
    public string GetStudentName();
    {
        return studentName;
    }
    public string GetTopic()
    {
        return topic;
    }
    public string GetSummary()
    {
        return _studentName + "_" + "_topic";
    }
    //public string GetSummaryList()
    //{
     //   return summaryList;
    }

}