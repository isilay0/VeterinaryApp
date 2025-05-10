using Microsoft.AspNetCore.Identity.Data;
using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Core;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Business
{
    public class AuthService(IDoctorRepository doctors) : IAuthService
    {
        private readonly IDoctorRepository repository = doctors;

        public async Task<string?> Login(LoginRequest req)
        {
            Doctor doctor = await repository.GetByEmail(req.Email) ?? throw new EntityNotFoundException("Aranan Doktor Bulunamadı.");

            if (ApplicationHelper.VerifyPassword(req.Password, doctor.Password!))
            {
                return ApplicationHelper.GenerateToken(doctor);
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }

        public async Task<Doctor> SignUp(Doctor req)
        {
            Doctor? doctor = await repository.GetByEmail(req.Email!);

            if (doctor != null)
            {
                throw new EntityAlreadyExistsException("Doktor zaten kayıtlı");
            } else
            {
                req.Password = ApplicationHelper.HashPassword(req.Password!);
                return await repository.Add(req);
            }
        }
    }
}
