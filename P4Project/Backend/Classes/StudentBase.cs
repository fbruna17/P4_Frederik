namespace P4Project.Backend.Classes
{
    // This is a super class for all instances of students fetched/initiated on runtime:
    // The class is abstract, as an instance from this class is never used:
    public abstract class StudentBase
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int ID { get; }

        public StudentBase(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
        }
    }
}
