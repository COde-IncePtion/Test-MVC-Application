namespace TestMvcApplication.Models
{
    public class Student
    {
        private int _rollNumber;
        private string _name;

        public int RollNumber => _rollNumber;

        public string Name => _name;

        public Student(int rollNumber, string name)
        {
            _rollNumber = rollNumber;
            _name = name;
        }
    }
}