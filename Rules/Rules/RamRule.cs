namespace Rules
{
    public class RamRule : ISystemRequirementsRule
    {
        public bool CheckRequirements(Computer computer)
        {
            var ruleResult = computer.Ram > 3;

            System.Console.WriteLine(string.Format("RamRule: {0}", ruleResult));
            return ruleResult;
        }
    }
}
