using Car_Rental.Business.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Common.Classes;
using Car_Rental.Common.Interfaces;
using System.Collections;
using System.Xml.Linq;
using Car_Rental.Common.Enums;
using Car_Rental.Data.Interfaces;
using Car_Rental.Business.Extensions;

namespace Car_Rental.Business.Extensions;

public static class BookingExtensions
{
    public static int CalculateKmDrived(this int kmRent, int? kmReturn)
    {
        if ((kmReturn <= 0) || (kmReturn == null))
        {
            return 0;
        }
        int KmReturnFix = (int)kmReturn;
        return KmReturnFix - kmRent;
    }
    public static int DaysRented(this DateTime rented, DateTime returned)
    {
        if (returned == default)
        { return 0; }
        TimeSpan diff = (returned - rented);
        int diffInt = int.Parse(diff.Days.ToString());
        return diffInt;
    }
    public static int CalculateCost(this BookingProcessor bp, string regNo, int kmRent, int? kmReturn, DateTime rented, DateTime returned)
    {
        var costPerKm = 0;
        int costPerDay = 0;
       
        foreach (var vehicle in bp.VehicleGetter())
        {
            if (vehicle.RegNumber == regNo)
            {
                costPerKm = vehicle.CostPerKm;
                costPerDay = vehicle.CostPerDay;
                break;
            }
        }
        int kmDrived = CalculateKmDrived(kmRent, kmReturn);
        int daysRent = DaysRented(rented, returned);
        int costKm = kmDrived * costPerKm;
        int costDays = daysRent * costPerDay;
        int totalCost = costKm + costDays;

        return totalCost;
    }
    public static DateTime GetLaterDate()
    {
        Random rnd = new Random();
        int randomDaysRented = rnd.Next(1, 10);
        DateTime laterDate = DateTime.Today.AddDays(randomDaysRented);
        return laterDate;
    }

}
