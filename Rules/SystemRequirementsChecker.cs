using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Rules
{
    public class SystemRequirementsChecker
    {
        private readonly IEnumerable<ISystemRequirementsRule> _rules;

        public SystemRequirementsChecker()
        {
            _rules = GetRules();
        }

        public bool CheckSystem(Computer computer)
        {
            return _rules.All(r => r.CheckRequirements(computer));
        }

        private IEnumerable<ISystemRequirementsRule> GetRules()
        {
            var currentAssembly = GetType().GetTypeInfo().Assembly;
            var requirementRules = currentAssembly
                .DefinedTypes
                .Where(type => type.ImplementedInterfaces.Any(i => i == typeof(ISystemRequirementsRule)))
                .Select(type => (ISystemRequirementsRule)Activator.CreateInstance(type))
                .ToList();

            return requirementRules;
        }
    }
}