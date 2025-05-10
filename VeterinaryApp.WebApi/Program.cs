using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Serilog;
using VeterinaryApp.WebApi;
using VeterinaryApp.WebApi.Business;
using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Repository;
using VeterinaryApp.WebApi.Repository.Abstractions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers().AddNewtonsoftJson(opt =>
{
    opt.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
    opt.SerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);
#region Customer services
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
#endregion
#region Animal services
builder.Services.AddScoped<IAnimalService, AnimalService>();
builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
#endregion
#region Appointment services
builder.Services.AddScoped<IAppoinmentService, AppoinmentService>();
builder.Services.AddScoped<IAppoinmentRepository , AppoinmentRepository>();
#endregion  
#region Clinic services
builder.Services.AddScoped<IClinicService, ClinicService>();
builder.Services.AddScoped<IClinicRepository, ClinicRepository>();
#endregion
#region Doctor services
builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
#endregion
#region Product services
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
#endregion
#region Treatment services
builder.Services.AddScoped<ITreatmentService, TreatmentService>();
builder.Services.AddScoped<ITreatmentRepository,  TreatmentRepository>();
#endregion
#region Bread services
builder.Services.AddScoped<IBreedService, BreedService>();
builder.Services.AddScoped<IBreedRepository, BreedRepository>();
#endregion
#region Species services
builder.Services.AddScoped<ISpeciesService, SpeciesService>();
builder.Services.AddScoped<ISpeciesRepository, SpeciesRepository>();
#endregion
#region Auth Services
builder.Services.AddScoped<IAuthService, AuthService>();
#endregion

builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL"));
    opt.UseLoggerFactory(LoggerFactory.Create(b => b.AddSerilog(logger)));
},ServiceLifetime.Scoped);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

