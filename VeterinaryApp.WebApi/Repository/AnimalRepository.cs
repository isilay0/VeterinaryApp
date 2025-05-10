using Microsoft.EntityFrameworkCore;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<AnimalRepository> logger;

        public AnimalRepository(AppDbContext context, ILogger<AnimalRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public async Task Add(Animal animal)
        {
            context.Animals.Add(animal);
            await context.SaveChangesAsync();
            
        }

        public async Task Delete(int id)
        {
            Animal animal = await context.Animals.FindAsync(id) ?? throw new EntityNotFoundException("Silinmek İstenen Hayvan Bulunamadı.");
            context.Animals.Remove(animal);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Animal>> GetAll()
        {
            return await context.Animals.ToListAsync();

        }

        public async Task<Animal[]> GetByCustomerId(int customerId)
        {
            IQueryable<Animal> query = from animal in context.Animals
                                       join breed in context.Breeds on animal.BreedId equals breed.Id
                                       join species in context.Species on animal.SpeciesId equals species.Id
                                       join doctor in context.Doctors on animal.DoctorId equals doctor.Id
                                       where animal.CustomerId == customerId
                                       //join customer in context.Customers on animal.CustomerId equals customer.Id
                                       select new Animal
                                       {
                                           Id = animal.Id,
                                           Doctor = animal.Doctor,
                                           Breed = breed,
                                           Species = species,
                                           Age = animal.Age,
                                           Blood = animal.Blood,
                                           Color = animal.Color,
                                           CustomerId = customerId,
                                           //Customer = customer,
                                           Disease = animal.Disease,
                                           Geld = animal.Geld,
                                           Gender = animal.Gender,
                                           HbsId = animal.HbsId,
                                           Name = animal.Name,
                                           Weight = animal.Weight,
                                       };

            //return await context.Animals.Where(x => x.CustomerId == customerId).ToArrayAsync();
            return await query.ToArrayAsync();
        }

        public async Task<Animal> GetById(int id)
        {
            Animal animal = await context.Animals.FindAsync(id) ?? throw new EntityNotFoundException("Aranan Hayvan Bulunamadı.");
            return animal;
        }

        public async Task Update(Animal animal)
        {
            bool exists = await context.Animals.AnyAsync(x => x.Id == animal.Id);
            if (!exists)
            {
                throw new EntityNotFoundException("Aranan Hayvan Bulunamadı.");
            }
            context.Animals.Update(animal);
            await context.SaveChangesAsync();
        }


    }
}
