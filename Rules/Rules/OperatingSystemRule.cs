namespace Rules
{
    public class OperatingSystemRule : ISystemRequirementsRule
    {
        public bool CheckRequirements(Computer computer)
        {
            return computer.OperatingSystem != "Linux";
        }
    }
}
