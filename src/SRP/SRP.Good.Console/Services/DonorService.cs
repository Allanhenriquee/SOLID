using SRP.Good.Console.Entities;

namespace SRP.Good.Console.Services;

public class DonorService
{
    public bool IsValidDonor(Donor donor)
    {
        //Peso mínimo para doação é de 50 KG.
        if (donor.Weight < 50)
            return false;

        //Idade para doar deve ser superior a 18 anos.
        if (DateTime.Now.Year - donor.BirthDate.Year < 18)
            return false;
        
        return true;
    }
}