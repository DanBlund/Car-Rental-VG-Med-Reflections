using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public abstract class Vehicle : IVehicle
{
    public int Id { get; set; }
    public string? RegNumber { get; init; }
    public string? Make { get; init; }
    public int Odometer { get; set; }
    public VehicleTypes VehicleType { get; init; }
    public int CostPerKm { get; set; }
    public int CostPerDay { get; set; }
    public BookingStatuses BookingStatus { get; set; }
}
