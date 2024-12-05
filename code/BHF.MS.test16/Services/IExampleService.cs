using BHF.MS.test16.Models;

namespace BHF.MS.test16.Services
{
    public interface IExampleService
    {
        Task<HttpResponseMessage> PostSomething(ExampleModel model);
        Task<HttpResponseMessage> GetSomething();
    }
}

