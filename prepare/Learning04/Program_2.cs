
namespace library_demo
{
    public class Assignment
    {
        protected string _studentName;
        private string _topic;

        public Assignment(string stuName, string tpc)
        {
            _studentName=stuName;
            _topic=tpc;
        }

        public string GetName()
        {
            return _studentName;
        }

        public string GetTopic()
        {
            return _topic;
        }
        public string GetSummary() 
        {
            return $"{_studentName} - {_topic}";
        }
    }


}

