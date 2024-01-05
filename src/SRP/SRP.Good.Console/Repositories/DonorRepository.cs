using SRP.Good.Console.Entities;

namespace SRP.Good.Console.Repositories;

public class DonorRepository
{
    public Donor GetById(int id)
    {
        return new Donor
        {
            Id = 1,
            FullName = "Allan Henrique",
            Email = "allan.henrique@teste.com.br",
            BirthDate = Convert.ToDateTime("01/01/2019"),
            Gender = "Masculino",
            Weight = 75,
            BloodType = "A",
            RhFactor = "Positivo"
        };
    }
}