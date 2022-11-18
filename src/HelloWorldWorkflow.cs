using System.Collections.Generic;
using Elsa.Activities.Console;
using Elsa.Activities.Signaling;
using Elsa.Builders;
using WorkflowTest.Activities;

namespace WorkflowTest;

public class HelloWorldWorkflow : IWorkflow
{
    public void Build(IWorkflowBuilder builder)
    {
        builder.WriteLine("Importing JSON")
        .Then<ImportJson>()
        .Then<DisplayKeys>();
    }
}
