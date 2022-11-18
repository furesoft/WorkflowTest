using System;
using System.Collections.Generic;
using Elsa.Activities.Compensation;
using Elsa.Activities.Console;
using Elsa.Activities.ControlFlow;
using Elsa.Activities.Signaling;
using Elsa.Builders;
using Esprima.Ast;
using WorkflowTest.Activities;

namespace WorkflowTest;

public class HelloWorldWorkflow : IWorkflow
{
    public void Build(IWorkflowBuilder builder)
    {
        builder
        .Then<Activities.Import>()
        .Then<DisplayKeys>();
    }
}
