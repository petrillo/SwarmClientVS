﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;

namespace SwarmClientVS
{
    public class SCStackFrameFunction
    {
        public string Name { get; set; }

        public SCStackFrameFunction(string name)
        {
            Name = name;
        }
    }
}