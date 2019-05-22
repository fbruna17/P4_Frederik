namespace P4Project.Backend.Classes
{
    // This Class is used as a struct, and as the Superclass of Skills on run time:
    public class Skill
    {
        public int ID { get; }
        public string Name { get; }

        public Skill(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
