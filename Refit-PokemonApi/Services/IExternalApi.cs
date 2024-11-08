using RefitApiExternalPost.Models;

namespace Refit.Services;

public interface IExternalApi
{
    [Post("/external")]
    //[Headers("Content-Type: application/json")]
    
    //Task<string> Message([Body] string message, [Authorize("Bearer")][Header("Authorization")] string authorization);
    
    Task<string> Message([Body] Response message);
}