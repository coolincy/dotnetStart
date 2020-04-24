using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AOA.AbpOnDocker.Pages
{
    public class Index_Tests : AbpOnDockerWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
