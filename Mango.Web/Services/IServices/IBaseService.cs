using Mango.Services.ProductAPI.Models.Dtos;
using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto responseDto { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
