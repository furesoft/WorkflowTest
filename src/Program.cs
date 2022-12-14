using System.Threading.Tasks;
using Elsa.Events;
using Elsa.Services;
using Microsoft.Extensions.DependencyInjection;
using WorkflowTest.Activities;

namespace WorkflowTest;

class Program
{
    private static async Task Main()
    {
        // Create a service container with Elsa services.
        var services = new ServiceCollection()
            .AddElsa(options => options
                .AddConsoleActivities()
                .AddActivitiesFrom<Import>()
                .AddWorkflow<HelloWorldWorkflow>())
            .BuildServiceProvider();

        // Get a workflow runner.
        var workflowRunner = services.GetRequiredService<IBuildsAndStartsWorkflow>();

        // Run the workflow.
        await workflowRunner.BuildAndStartWorkflowAsync<HelloWorldWorkflow>(input:
            new Elsa.Models.WorkflowInput("https://support.oneskyapp.com/hc/en-us/article_attachments/202761627/example_1.json2")
        );
    }
}