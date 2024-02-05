using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;

namespace AzureWebAPIWSD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private Container cosmosDbContainer;

    private string databaseId = "data";
    private string containerName = "container";

    public UserController(IConfiguration configuration)
    {
        var connectionString = configuration["ConnectionString"];
        var client = new CosmosClient(connectionString);
        this.cosmosDbContainer = client.GetContainer(databaseId, containerName);
    }

        // POST api/values
        [HttpPost]
        public async void Post([FromBody] User user)
        {
            await this.cosmosDbContainer.CreateItemAsync<User>(user);
        }


    }
}
