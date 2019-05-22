namespace P4Project
{
    // This Class is used as a struct and super class for all instances of an SME initiated on runtime:
    public class SMEBase
    {
        public int ID { get; }
        public string Name { get; }
        public string Email { get; }

        // Instances of this class is only initiated as : base() from childclasses
        // Or when fetching data, to store temporate data in a struct:
        public SMEBase(int id, string name, string email)
        {
            ID = id;
            Name = name;
            Email = email;
        }
    }
}
