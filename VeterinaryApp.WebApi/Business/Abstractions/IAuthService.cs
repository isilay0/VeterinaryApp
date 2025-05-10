using Microsoft.AspNetCore.Identity.Data;
using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Business.Abstractions
{
    public interface IAuthService
    {
        Task<string?> Login(LoginRequest req);
        Task<Doctor> SignUp(Doctor req);
    }
}
