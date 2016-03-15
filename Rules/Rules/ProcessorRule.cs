namespace Rules
{
    public class ProcessorRule : ISystemRequirementsRule
    {
        public bool CheckRequirements(Computer computer)
        {
            var ruleResult = computer.Ghz > 3.0;
            System.Console.WriteLine(string.Format("ProcessorRule: {0}", ruleResult));

            return ruleResult;
        }
    }
}