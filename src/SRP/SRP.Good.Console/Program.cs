using SRP.Good.Console.Entities;
using SRP.Good.Console.Services;

var donation = new Donation
{
    Id = 1,
    DonorId = 2,
    DonationAt = DateTime.Now.AddDays(-40),
    QuantityMl = 450
};

var donationService = new DonationService();

var result = donationService.CreateDonation(donation);

Console.WriteLine($"Donation created is {result}");
Console.ReadKey();