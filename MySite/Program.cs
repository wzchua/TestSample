using System;
using System.Threading.Tasks;
using Statiq.App;
using Statiq.Common;
using Statiq.Web;

namespace MySite
{
    class Program
    {
        public static async Task<int> Main(string[] args) =>
        await Bootstrapper
            .Factory
            .CreateWeb(args)
            .DeployToGitHubPages(
                "wzchua",
                "TestSample",
                Config.FromSetting<string>("GITHUB_TOKEN")
            )
            .RunAsync();
    }
}
