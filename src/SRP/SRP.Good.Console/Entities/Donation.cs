namespace SRP.Good.Console.Entities;

public class Donation
{
    public int Id { get; set; }
    public int DonorId { get; set; }
    public DateTime DonationAt { get; set; }
    public int QuantityMl { get; set; }
}