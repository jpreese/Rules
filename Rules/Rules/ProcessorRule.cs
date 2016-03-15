using System;

namespace Rules
{
    public class ProcessorRule : ISystemRequirementsRule
    {
        public bool CheckRequirements(Computer computer)
        {
            return computer.Ghz > 3.0;
        }
    }
}
