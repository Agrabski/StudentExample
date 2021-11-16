namespace StudentExample
{
    // Student jest zapisany na przedmioty
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int StudentId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Credit { get; set; }
    }

    public class Class
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int ECTS { get; set; }
        public int Cost { get; set; }
    }
}