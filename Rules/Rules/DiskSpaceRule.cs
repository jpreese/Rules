namespace Rules.Rules
{
    class DiskSpaceRule : ISystemRequirementsRule
    {
        public bool CheckRequirements(Computer computer)
        {
            return computer.DiskSpace > 10;
        }
    }
}
