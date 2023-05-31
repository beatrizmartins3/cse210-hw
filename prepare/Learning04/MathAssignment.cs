namespace library_demo
{
    public class MathAssignment : Assignment
    {
        private string _textbookSection="";
        private string _problems="";

        public MathAssignment(string textBook, string problems, string stuName,string tpc ) : base(stuName,tpc)
        {
            _textbookSection=textBook;
            _problems=problems;
        }

        
        
        public string GetHomeworkList()
        {
            return $"Section {_textbookSection}  Problems { _problems} ";
        }
    }
}