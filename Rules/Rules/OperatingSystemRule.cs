namespace Rules
{
    public class OperatingSystemRule : ISystemRequirementsRule
    {
        public bool CheckRequirements(Computer computer)
        {
            var ruleResult = computer.OperatingSystem != "Linux";
            System.Console.WriteLine(string.Format("OperaringSystemRule: {0}", ruleResult));

            return ruleResult;
        }
    }
}


