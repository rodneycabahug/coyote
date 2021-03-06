﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Xunit.Abstractions;

namespace Microsoft.Coyote.SystematicTesting.Tests.Tasks
{
    public class TaskRunTests : Microsoft.Coyote.Production.Tests.Tasks.TaskRunTests
    {
        public TaskRunTests(ITestOutputHelper output)
            : base(output)
        {
        }

        public override bool SystematicTest => true;
    }
}
