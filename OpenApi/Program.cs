using OpenApi.PetClient;

using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace OpenApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection()
                .Configure<PetClientOptions>(o => { })
                .BuildServiceProvider();
            
            var client = new PetStoreClient(services.GetRequiredService<IOptionsSnapshot<PetClientOptions>>(), new System.Net.Http.HttpClient());
            await client.AddPetAsync(new Pet
            {
                Category = new Category() { Id = 1, Name = "asdfasdf" },
                Name = "asdfasdf"
            });
            Console.WriteLine("Hello World!");
        }
    }
}
