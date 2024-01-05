using SRP.Bad.Console;

var donation = new Donation
{
    Id = 1,
    DonorId = 2,
    DonationAt = DateTime.Now.AddDays(-40),
    QuantityMl = 450
};

var result = donation.CreateDonation();

Console.WriteLine($"Donation created is {result}");
Console.ReadKey();