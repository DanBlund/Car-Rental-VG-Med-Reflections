using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using System.Xml.Linq;

namespace Car_Rental.Common.Classes;

public class Booking : IBooking
{
    public int Id { get; set; }
    public string RegNumber { get; init; }
    public string Customer { get; init; }
    public int KmRented { get; init; }
    public int? KmReturned { get; set; }
    public DateTime Rented { get; init; }
    public DateTime Returned { get; set; }
    public int? Cost { get; set; }
    public BookingStatuses BookingStatus { get; set; }

    public Booking(int id, string regNo, string cust, int kmRent, int? kmReturn, DateTime rented, DateTime returned, int? cost, BookingStatuses status)
    {
        Id = id;
        RegNumber = regNo;
        Customer = cust;
        KmRented = kmRent;
        KmReturned = kmReturn;
        Rented = rented;
        Returned = returned;
        Cost = cost;
        BookingStatus = status;
    }
}
