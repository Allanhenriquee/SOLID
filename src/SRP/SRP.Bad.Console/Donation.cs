namespace SRP.Bad.Console;

public class Donation
{
    public int Id { get; set; }
    public int DonorId { get; set; }
    public DateTime DonationAt { get; set; }
    public int QuantityMl { get; set; }

    public bool CreateDonation()
    {
        //Simulando uma lista recebida de um repositório.
        var repositorio = new List<int> { 1, 2, 3, };
        
        //Simulando uma entidade doador quando recuperar as infos do repositorio já teria esses dados.
        var donor = new
        {
            Id = 1,
            FullName = "Allan Henrique",
            Email = "allan.henrique@teste.com.br",
            BirthDate = Convert.ToDateTime("01/01/1993"),
            Gender = "Masculino",
            Weight = 75,
            BloodType = "A",
            RhFactor = "Positivo"
        };

        //consultando no banco para ver se existe o Id daquele doador.
        if (!repositorio.Contains(DonorId))
            return false;

        //Peso mínimo para doação é de 50 KG.
        if (donor.Weight < 50)
            return false;

        //Idade para doar deve ser superior a 18 anos.
        if (DateTime.Now.Year - donor.BirthDate.Year < 18)
            return false;
        
        //Homens só podem doar de 60 em 60 dias e Mulheres de 90 em 90 dias.
        var daysOfRecovery = donor.Gender == "Masculino" ? 60 : 90;
        var daysOfLastDonation = (DateTime.Today - DonationAt).Days;

        if (daysOfLastDonation < daysOfRecovery)
            return false;
        
        return true;
    }
}