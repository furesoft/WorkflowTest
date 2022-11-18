using System.Net.Http;
using System.Threading.Tasks;
using Elsa.ActivityResults;
using Elsa.Services;
using Elsa.Services.Models;
using Newtonsoft.Json;

namespace WorkflowTest.Activities;

public class ImportJson : Activity
{
    public override async ValueTask<IActivityExecutionResult> ExecuteAsync(ActivityExecutionContext context)
    {
        var client = new HttpClient();
        var json = await client.GetStringAsync("https://support.oneskyapp.com/hc/en-us/article_attachments/202761627/example_1.json");
        var obj = JsonConvert.DeserializeObject(json);


        return Done(obj);
    }
}
