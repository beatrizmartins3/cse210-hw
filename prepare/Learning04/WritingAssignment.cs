namespace library_demo
{
    public class WritingAssignment : Assignment
    {
        private string _title="";

        public WritingAssignment(string tittle, string stuName, string tpc) : base(stuName, tpc)
        {
            _title=tittle;
        }

        public string GetWritingInformation()
        {
            return $"{_title} by {_studentName}";
        }
    }
}