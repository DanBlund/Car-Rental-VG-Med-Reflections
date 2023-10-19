using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Motorcycle : Vehicle
{
    public Motorcycle(int id, string regNo, string make, int odo, VehicleTypes veType, int costKm, int costDay, BookingStatuses status) =>
        (Id, RegNumber, Make, Odometer, VehicleType, CostPerKm, CostPerDay, BookingStatus) = (id, regNo, make, odo, veType, costKm, costDay, status);

}
