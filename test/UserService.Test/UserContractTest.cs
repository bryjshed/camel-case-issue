using Xunit;
using Xunit.Abstractions;

namespace UserService.Test
{
    public class UserContractTest : IClassFixture<TestServerFixture>
    {
        private readonly TestServerFixture _fixture;

        private readonly ITestOutputHelper _output;

        public UserContractTest(TestServerFixture fixture, ITestOutputHelper output)
        {
            _fixture = fixture;
            _output = output;
        }

        [Fact]
        public async void TestGetInvalid()
        {
            var getResponse = await _fixture.Client.GetAsync($"/user/");
            var fetched = await getResponse.Content.ReadAsStringAsync();
            
            //check errors for camelCase
            // See comments on startup.cs for AddJsonFormatters
            Assert.True(fetched.Contains("userId"));
            Assert.True(fetched.Contains("firstName"));
            Assert.True(fetched.Contains("lastName"));
        }

        [Fact]
        public async void TestGetValid()
        {
            var getResponse = await _fixture.Client.GetAsync($"/user/?userId=2132&firstName=Test&lastName=Test");
            var fetched = await getResponse.Content.ReadAsStringAsync();

            Assert.True(fetched.Contains("userId"));
            Assert.True(fetched.Contains("firstName"));
            Assert.True(fetched.Contains("lastName"));
        }


    }
}