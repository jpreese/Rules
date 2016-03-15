namespace Rules.Rules
{
    class DiskSpaceRule : ISystemRequirementsRule
    {
        public bool CheckRequirements(Computer computer)
        {
            var ruleResult = computer.DiskSpace > 10;
            System.Console.WriteLine(string.Format("DiskSpaceRule: {0}", ruleResult));

            return ruleResult;
        }
    }
}



