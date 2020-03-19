namespace Lab3
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName} {MiddleName}";
        }
    }
}
