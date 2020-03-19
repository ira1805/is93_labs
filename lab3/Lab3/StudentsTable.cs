namespace Lab3
{
    class StudentsTable
    {
        private Student[] _students;

        public StudentsTable(int size)
        {
            _students = new Student[size];
        }

        public Student this[int index]
        {
            get
            {
                return _students[index];
            }
            set
            {
                _students[index] = value;
            }
        }
    }
}
