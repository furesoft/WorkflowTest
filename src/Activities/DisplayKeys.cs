using System;
using System.Threading.Tasks;
using Elsa.ActivityResults;
using Elsa.Services;
using Elsa.Services.Models;
using Newtonsoft.Json.Linq;

namespace WorkflowTest.Activities;

public class DisplayKeys : Activity
{
    public override async ValueTask<IActivityExecutionResult> ExecuteAsync(ActivityExecutionContext context)
    {
        var obj = (JObject)context.Input;

        foreach (var kv in obj)
        {
            Console.WriteLine(kv.Key);
        }

        return Done();
    }
}