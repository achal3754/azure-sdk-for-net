﻿// Copyright (c) Microsoft Corporation
// All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not
// use this file except in compliance with the License.  You may obtain a copy
// of the License at http://www.apache.org/licenses/LICENSE-2.0
// 
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED
// WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
// 
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.
namespace Microsoft.WindowsAzure.Management.HDInsight.TestUtilities.PowerShellTestAbstraction.Concreates
{
    using System.Management.Automation.Runspaces;
    using Microsoft.WindowsAzure.Management.HDInsight.TestUtilities.PowerShellTestAbstraction.Interfaces;

    public class CommandAbstraction : PipelineAbstraction, ICommand
    {
        protected Command Command { get; private set; }

        internal CommandAbstraction(Command command, Pipeline pipeline, Runspace runsapce)
            : base(pipeline, runsapce)
        {
            this.Command = command;
        }

        public ICommand WithParameter(string name, object value)
        {
            this.Command.Parameters.Add(name, value);
            return this;
        }
    }
}
