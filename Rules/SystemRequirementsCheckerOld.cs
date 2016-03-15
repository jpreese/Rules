﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules
{
    public class SystemRequirementsCheckerOld
    {
        public bool CheckSystem(Computer computer)
        {
            if (computer.Ghz < 3)
            {
                return false;
            }

            if (computer.Ram < 4)
            {
                return false;
            }

            if (computer.DiskSpace < 10)
            {
                return false;
            }

            if (computer.OperatingSystem != "Windows")
            {
                return false;
            }

            return true;
        }
    }
}
