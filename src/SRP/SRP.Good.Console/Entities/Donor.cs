namespace SRP.Good.Console.Entities;

public class Donor
{
    public int Id { get; set; }
    public string FullName { get;  set; }
    public string Email { get;  set; }
    public DateTime BirthDate { get;  set; }
    public string Gender { get;  set; }
    public double Weight { get;  set; }
    public string BloodType { get;  set; }
    public string RhFactor { get;  set; }
}