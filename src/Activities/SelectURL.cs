using System.Threading.Tasks;
using Elsa.ActivityResults;
using Elsa.Services;
using Elsa.Services.Models;

namespace WorkflowTest.Activities;

public class SelectURL : Activity
{
    public override ValueTask<IActivityExecutionResult> ExecuteAsync(ActivityExecutionContext context)
    {
        context.Output = "https://support.oneskyapp.com/hc/en-us/article_attachments/202761627/example_1.json2";
        return ValueTask.FromResult<IActivityExecutionResult>(Done(context.Output));
    }
}
