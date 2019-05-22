namespace P4Project.Backend.Classes
{
    // This Class is used to handle studentsskills on runtime, as it now enables differentiating between verified and unverified skill:
    public class SkillStudent : Skill
    {
        public bool Verified { get; }

        public SkillStudent(int id, string name, bool verified) : base(id, name)
        {
            Verified = verified;
        }

        // The Method that returns the string[] for DataViewGrids: (Used on StudentProfileView)
        public string[] MakeDataViewGrid()
        {
            if(Verified)
            {
                string[] output = { Name, "Yes" };
                return output;
            }
            else
            {
                string[] output = { Name, "No" };
                return output;
            }
        }
    }
}
