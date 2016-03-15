using System;

namespace Rules
{
    public class RamRule : ISystemRequirementsRule
    {
        public bool CheckRequirements(Computer computer)
        {
            return computer.Ram > 3;
        }
    }
}
