using Elsa.Activities.Console;
using Elsa.Builders;

namespace WorkflowTest
{
    public class HelloWorldWorkflow : IWorkflow
    {
        public void Build(IWorkflowBuilder builder) => builder.WriteLine("Hello World!");
    }
}