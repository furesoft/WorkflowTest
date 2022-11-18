using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Elsa.ActivityResults;
using Elsa.Services;
using Elsa.Services.Models;
using Newtonsoft.Json;

namespace WorkflowTest.Activities;


public class Import : Activity
{
    public override async ValueTask<IActivityExecutionResult> ExecuteAsync(ActivityExecutionContext context)
    {
        string url = context.GetInput<string>();
        if (url.EndsWith(".json"))
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync(context.GetInput<string>());
            var obj = JsonConvert.DeserializeObject(json);

            return Done(obj);
        }

        return Fault($"No Import Provider For Filetype '{Path.GetExtension(url)}' registered!");
    }
}