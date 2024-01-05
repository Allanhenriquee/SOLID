using SRP.Good.Console.Entities;
using SRP.Good.Console.Repositories;

namespace SRP.Good.Console.Services;

public class DonationService
{
    public bool CreateDonation(Donation donation)
    {
        //No dia a dia você irá usar interfaces e usar injeção de dependencia.
        //Instanciando o repository apenas para o exemplo.
        var donorRepository = new DonorRepository();
        var donor = donorRepository.GetById(donation.DonorId);

        //Se o Id do donor não existir retorna erro direto no service.
        if (donor is null)
            return false;

        //Instanciando o service apenas para o exemplo.
        //Validações de donor está no service de donor.
        //Validações de peso, idade, dias.
        var donorService = new DonorService();
        var isValidDonor = donorService.IsValidDonor(donor);

        //Instanciando o repository apenas para o exemplo.
        var donationRepository = new DonationRepository();

        if (!isValidDonor)
            return false;
        
        //Adiciona no repository a donation.
        donationRepository.Add(donation);
        
        return true;
    }
}